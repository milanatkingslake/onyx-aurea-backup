using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using OnyxMessageSubsystem.SubscribeNotificationServices;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Common" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
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

        #region General Initializer : Class (Common) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodGetUserIdFromSession = "GetUserIdFromSession";
        private const string MethodGetFirstDayOfWeek = "GetFirstDayOfWeek";
        private const string MethodGetFirstDayOfMonth = "GetFirstDayOfMonth";
        private const string MethodGetFirstDayOfQuarter = "GetFirstDayOfQuarter";
        private const string MethodGetFirstDayOfYear = "GetFirstDayOfYear";
        private const string MethodGetMessage = "GetMessage";
        private const string MethodGetNodeValue = "GetNodeValue";
        private const string MethodSetNodeValue = "SetNodeValue";
        private const string MethodGetRelativePath = "GetRelativePath";
        private const string MethodDecryptText = "DecryptText";
        private const string MethodDecryptConnectionString = "DecryptConnectionString";
        private const string MethodMergeConfigXml = "MergeConfigXml";
        private const string MethodSafeGetFromHashTables = "SafeGetFromHashTables";
        private const string MethodGetErrorMessageFromResourceAssembly = "GetErrorMessageFromResourceAssembly";
        private const string MethodExecuteQuery = "ExecuteQuery";
        private const string MethodExecuteLboMethod = "ExecuteLboMethod";
        private const string MethodSortByAttribute = "SortByAttribute";
        private const string MethodgetIndividualNamingFormat = "getIndividualNamingFormat";
        private const string MethodgetIndividualName = "getIndividualName";
        private const string MethodaddNode = "addNode";
        private const string MethodIgnoreXmlComments = "IgnoreXmlComments";
        private const string MethodBatchUpdateMapping = "BatchUpdateMapping";
        private const string MethodGetContextData = "GetContextData";
        private const string MethodGetLocalXMLString = "GetLocalXMLString";
        private const string MethodGetMobileProfileName = "GetMobileProfileName";
        private const string MethodGetOwnerTypeForMobile = "GetOwnerTypeForMobile";
        private const string MethodGetEntityNameForMobile = "GetEntityNameForMobile";

        #endregion

        #region Fields

        private const string FieldLBO_OBJECT_WATCH = "LBO_OBJECT_WATCH";
        private const string FieldLBO_METHOD_WATCH_INSERTUPDATE = "LBO_METHOD_WATCH_INSERTUPDATE";
        private const string FieldLBO_METHOD_RETRIEVELISTBY_USERID = "LBO_METHOD_RETRIEVELISTBY_USERID";
        private const string FieldLBO_INCIDENT_EVENT_DATA = "LBO_INCIDENT_EVENT_DATA";
        private const string FieldXPATH_DETAILS_TEMPLATE_IDS = "XPATH_DETAILS_TEMPLATE_IDS";
        private const string FieldXPATH_LIST_TEMPLATE_IDS = "XPATH_LIST_TEMPLATE_IDS";
        private const string FieldXPATH_METADATA_TEMPLATE_IDS = "XPATH_METADATA_TEMPLATE_IDS";
        private const string FieldXPATH_DETAILS_PROFILE_COLUMNAMES = "XPATH_DETAILS_PROFILE_COLUMNAMES";
        private const string FieldXPATH_LIST_PROFILE_COLUMNAMES = "XPATH_LIST_PROFILE_COLUMNAMES";
        private const string FieldXPATH_LIST_PROFILE_GROUPS = "XPATH_LIST_PROFILE_GROUPS";
        private const string FieldXPATH_LBORESULT_COLUMN_DEFINTIONS = "XPATH_LBORESULT_COLUMN_DEFINTIONS";
        private const string FieldMENUID = "MENUID";
        private const string FieldWATCH_RETRIEVELIST_USERID_PARAM_XML = "WATCH_RETRIEVELIST_USERID_PARAM_XML";
        private const string FieldWATCH_INSERTUPDATE_PARAM_XML = "WATCH_INSERTUPDATE_PARAM_XML";
        private const string FieldRETRIVE_PARAM_XML = "RETRIVE_PARAM_XML";
        private const string FieldRESULT_GRID_DEFAULT_MIN_ROWS = "RESULT_GRID_DEFAULT_MIN_ROWS";
        
        private const string FieldPARAMETER_DELIMITER = "PARAMETER_DELIMITER";
        private const string FieldMULTIPLE_PARAMETER_DELIMITER = "MULTIPLE_PARAMETER_DELIMITER";
        private const string FieldSQL_WHERE = "SQL_WHERE";
        private const string FieldSQL_AND = "SQL_AND";
        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldNAVIGATOR_ENTITY_ID = "NAVIGATOR_ENTITY_ID";
        private const string FieldFIELD_ID = "FIELD_ID";
        private const string FieldDISPLAY_NAME = "DISPLAY_NAME";
        private const string FieldSEQUENCE_INDEX = "SEQUENCE_INDEX";
        private const string FieldIS_EDITABLE = "IS_EDITABLE";
        private const string FieldFIELD_STATE = "FIELD_STATE";
        private const string FieldMAX_RECORDS = "MAX_RECORDS";
        private const string FieldSORT_ORDER = "SORT_ORDER";
        private const string FieldSORT_BY = "SORT_BY";
        private const string FieldSORT_TYPE = "SORT_TYPE";
        private const string FieldCONTENT = "CONTENT";
        private const string FieldUI_RESOURCE = "UI_RESOURCE";
        private const string FieldPAGE_SIZE = "PAGE_SIZE";
        private const string FieldIS_REQUIRED = "IS_REQUIRED";
        private const string FieldPARAMETER = "PARAMETER";
        private const string FieldPARAMETERS = "PARAMETERS";
        private const string FieldMODE = "MODE";
        private const string FieldCREDENTIAL = "CREDENTIAL";
        private const string FieldAPPLICATION_NAME = "APPLICATION_NAME";
        private const string FieldSITE_ID = "SITE_ID";
        private const string FieldLANG_CODE = "LANG_CODE";
        private const string FieldREQUEST_TO_QAS = "REQUEST_TO_QAS";
        private const string FieldQUERY_ID = "QUERY_ID";
        private const string FieldQUERY_NAME = "QUERY_NAME";
        private const string FieldQUERY_TYPE = "QUERY_TYPE";
        private const string FieldQUERY_MODE = "QUERY_MODE";
        private const string FieldPROTECTION_MODE = "PROTECTION_MODE";
        private const string FieldQUERY_PARAMETER = "QUERY_PARAMETER";
        private const string FieldGROUP = "GROUP";
        private const string FieldIS_BOOKMARK = "IS_BOOKMARK";
        private const string FieldIS_HOME_PAGE_QUERY = "IS_HOME_PAGE_QUERY";
        private const string FieldFOLDER_NAME = "FOLDER_NAME";
        private const string FieldPARENT_FOLDER_ID = "PARENT_FOLDER_ID";
        private const string FieldFOLDER_ID = "FOLDER_ID";
        private const string FieldPUBLIC_FOLDER_ID = "PUBLIC_FOLDER_ID";
        private const string FieldPERSONAL_FOLDER_ID = "PERSONAL_FOLDER_ID";
        private const string FieldCOUNTRY_ID = "COUNTRY_ID";
        private const string FieldPARENT_ID = "PARENT_ID";
        private const string FieldIS_MOBILEBOOKMARK = "IS_MOBILEBOOKMARK";
        private const string FieldWATCH = "WATCH";
        private const string FieldCLIENT_DATETIME = "CLIENT_DATETIME";
        private const string FieldCLIENT_UTC_OFFSET = "CLIENT_UTC_OFFSET";
        private const string FieldPAGE_INDEX = "PAGE_INDEX";
        private const string FieldAPP_ID = "APP_ID";
        private const string FieldAPP_KEY = "APP_KEY";
        private const string FieldSEARCH_STRING = "SEARCH_STRING";
        private const string FieldUSER_ID = "USER_ID";
        private const string FieldORIGINAL_USER_ID = "ORIGINAL_USER_ID";
        private const string FieldCONTENT_TYPE = "CONTENT_TYPE";
        private const string FieldACTION = "ACTION";
        private const string FieldTRANSACTION_CREATE = "TRANSACTION_CREATE";
        private const string FieldTRANSACTION_APPEND = "TRANSACTION_APPEND";
        private const string FieldTRANSACTION_UPDATE = "TRANSACTION_UPDATE";
        private const string FieldTRANSACTION_DELETE = "TRANSACTION_DELETE";
        private const string FieldTRANSACTION_RENAME = "TRANSACTION_RENAME";
        private const string FieldSearch_type = "Search_type";
        private const string FieldLBO_NAME = "LBO_NAME";
        private const string FieldLBO_Method = "LBO_Method";
        private const string FieldLBO_METHOD_NAME = "LBO_METHOD_NAME";
        private const string FieldLBO_OBJECT_NAME = "LBO_OBJECT_NAME";
        private const string FieldTIME_STAMP = "TIME_STAMP";
        private const string FieldPRIMARY_ID = "PRIMARY_ID";
        private const string FieldOWNER_ID = "OWNER_ID";
        private const string FieldOWNER_TYPE = "OWNER_TYPE";
        private const string FieldCATEGORY_ID = "CATEGORY_ID";
        private const string FieldGROUP_TYPE_ID = "GROUP_TYPE_ID";
        private const string FieldACTIVE = "ACTIVE";
        private const string FieldcallFrom = "callFrom";
        private const string FieldSTATUS_ID = "STATUS_ID";
        private const string FieldFILENAME = "FILENAME";
        private const string FieldEXTENSION = "EXTENSION";
        private const string FieldprofileName = "profileName";
        private const string FieldREMINDER_PRIMARY_ID = "REMINDER_PRIMARY_ID";
        private const string FieldREMINDER_RECALL_TIME = "REMINDER_RECALL_TIME";
        private const string FieldREMINDER_RECALL_DATE = "REMINDER_RECALL_DATE";
        private const string FieldPHONE_PRIMARY_ID = "PHONE_PRIMARY_ID";
        private const string FieldPHONE_TIME_STAMP = "PHONE_TIME_STAMP";
        private const string FieldPHONE_NUMBER = "PHONE_NUMBER";
        private const string FieldPHONE_TYPE = "PHONE_TYPE";
        private const string FieldPHONE_OWNER_ID = "PHONE_OWNER_ID";
        private const string FieldPHONE_OWNER_TYPE = "PHONE_OWNER_TYPE";
        private const string FieldADDRESS_PRIMARY_ID = "ADDRESS_PRIMARY_ID";
        private const string FieldADDRESS_TIME_STAMP = "ADDRESS_TIME_STAMP";
        private const string FieldADDRESS_CITY = "ADDRESS_CITY";
        private const string FieldADDRESS_STATE = "ADDRESS_STATE";
        private const string FieldADDRESS_COUNTRY = "ADDRESS_COUNTRY";
        private const string FieldADDRESS_POSTAL_CODE = "ADDRESS_POSTAL_CODE";
        private const string FieldADDRESS_OWNER_ID = "ADDRESS_OWNER_ID";
        private const string FieldADDRESS_OWNER_TYPE = "ADDRESS_OWNER_TYPE";
        private const string FieldCOMPANY_CONTACT_FIRST_NAME = "COMPANY_CONTACT_FIRST_NAME";
        private const string FieldCOMPANY_CONTACT_LAST_NAME = "COMPANY_CONTACT_LAST_NAME";
        private const string FieldINDIVIDUAL_FIRST_NAME = "INDIVIDUAL_FIRST_NAME";
        private const string FieldINDIVIDUAL_LAST_NAME = "INDIVIDUAL_LAST_NAME";
        private const string FieldINCIDENT_OWNER_ID = "INCIDENT_OWNER_ID";
        private const string FieldINCIDENT_OWNER_TYPE = "INCIDENT_OWNER_TYPE";
        private const string FieldINCIDENT_CATEGORY_ID = "INCIDENT_CATEGORY_ID";
        private const string FieldINCIDENT_CONTACT_FIRST_NAME = "INCIDENT_CONTACT_FIRST_NAME";
        private const string FieldINCIDENT_CONTACT_LAST_NAME = "INCIDENT_CONTACT_LAST_NAME";
        private const string FieldINCIDENT_OWNER_TIMESTAMP = "INCIDENT_OWNER_TIMESTAMP";
        private const string FieldREMINDER_OWNER_ID = "REMINDER_OWNER_ID";
        private const string FieldREMINDER_OWNER_TYPE = "REMINDER_OWNER_TYPE";
        private const string FieldREMINDER_DUEBY = "REMINDER_DUEBY";
        private const string FieldPARENT_GROUP_ID = "PARENT_GROUP_ID";
        private const string FieldCONTACT_ID = "CONTACT_ID";
        private const string FieldCONTACT_TYPE_ID = "CONTACT_TYPE_ID";
        private const string FieldOBJECT_TYPE_ID = "OBJECT_TYPE_ID";
        private const string FieldTAGS_CATEGORY_ID = "TAGS_CATEGORY_ID";
        private const string FieldTAGS_OBJECT_TYPE_ENUM = "TAGS_OBJECT_TYPE_ENUM";
        private const string FieldSOURCE_PRIMARY_ID = "SOURCE_PRIMARY_ID";
        private const string FieldTARGET_PRIMARY_ID = "TARGET_PRIMARY_ID";
        private const string FieldEXCEPTION_HANDLE = "EXCEPTION_HANDLE";
        private const string FieldPARAM_XML = "PARAM_XML";
        private const string FieldCUSTOM_XML = "CUSTOM_XML";
        private const string FieldRESOURCE_ID = "RESOURCE_ID";
        private const string FieldTWITTER_SCREEN_NAME = "TWITTER_SCREEN_NAME";
        private const string FieldAPPLICATION_TYPE = "APPLICATION_TYPE";
        private const string FieldMobileUserLoginPermission = "MobileUserLoginPermission";
        private const string FieldEMFUserLoginPermission = "EMFUserLoginPermission";
        private const string FieldAnalyticsLoginPermission = "AnalyticsLoginPermission";
        private const string FieldOEPLoginPermission = "OEPLoginPermission";
        private const string FieldRlcAdministrationResource = "RlcAdministrationResource";
        private const string FieldRESOURCE_SEARCH_FILTER_ADMINISTRATION = "RESOURCE_SEARCH_FILTER_ADMINISTRATION";
        private const string FieldRESOURCE_RLC_DISABLED_LIST = "RESOURCE_RLC_DISABLED_LIST";
        private const string FieldRESOURCE_RLC_AVAILABLE_LIST = "RESOURCE_RLC_AVAILABLE_LIST";
        private const string FieldRESOURCE_RLC_HEADER_LIST = "RESOURCE_RLC_HEADER_LIST";
        private const string FieldDefaultSearchFilterList = "DefaultSearchFilterList";
        private const string FieldAvailableSearchFilterList = "AvailableSearchFilterList";
        private const string FieldDisabledSearchFilterList = "DisabledSearchFilterList";
        private const string FieldQUERY_EXPLORER_SHOW_PUBLIC_FOLDER = "QUERY_EXPLORER_SHOW_PUBLIC_FOLDER";
        private const string FieldMODULE_ID = "MODULE_ID";
        private const string FieldPLP_TOKEN = "PLP_TOKEN";
        private const string FieldPROFILE_ID = "PROFILE_ID";
        private const string FieldTIME_ZONE_OFFSET = "TIME_ZONE_OFFSET";
        private const string FieldREQUEST_FOR_DOCK_QUERY = "REQUEST_FOR_DOCK_QUERY";
        private const string FieldInActivePlpToken = "InActivePlpToken";
        private const string FieldDATA_TYPE_DATETIME = "DATA_TYPE_DATETIME";
        private const string FieldDATA_TYPE_ENUM_INTEGER = "DATA_TYPE_ENUM_INTEGER";
        private const string FieldDATA_TYPE_INTEGER = "DATA_TYPE_INTEGER";
        private const string FieldDATA_TYPE_FLOAT = "DATA_TYPE_FLOAT";
        private const string FieldDATA_TYPE_BIT = "DATA_TYPE_BIT";
        private const string FieldFORMAT_DATE = "FORMAT_DATE";
        private const string FieldFORMAT_DATE_TIME = "FORMAT_DATE_TIME";
        private const string FieldFORMAT_STARTDATE24 = "FORMAT_STARTDATE24";
        private const string FieldFORMAT_ENDDATE24 = "FORMAT_ENDDATE24";
        private const string FieldFORMAT_DATE_TIME24_STRING = "FORMAT_DATE_TIME24_STRING";
        private const string FieldFORMAT_DATE_TIME24 = "FORMAT_DATE_TIME24";
        private const string FieldSQLFORMAT_DATE_TIME24 = "SQLFORMAT_DATE_TIME24";
        private const string FieldFORMAT_LOGICAL_EXPRESSION_BETWEEN = "FORMAT_LOGICAL_EXPRESSION_BETWEEN";
        private const string FieldMASK_DELIMITER = "MASK_DELIMITER";
        private const string FieldLOG_NAME = "LOG_NAME";
        private const string FieldLOG_SOURCE_NAME = "LOG_SOURCE_NAME";
        private const string FieldLOG_LEVEL = "LOG_LEVEL";
        private const string FieldFORMAT_EXCEPTION_METHOD = "FORMAT_EXCEPTION_METHOD";
        private const string FieldEMF_KEY = "EMF_KEY";
        private const string FieldNAVIGATOR_COMPANY_ENTITY = "NAVIGATOR_COMPANY_ENTITY";
        private const string FieldNAVIGATOR_INDIVIDUAL_ENTITY = "NAVIGATOR_INDIVIDUAL_ENTITY";
        private const string FieldNAVIGATOR_SALES_ENTITY = "NAVIGATOR_SALES_ENTITY";
        private const string FieldNAVIGATOR_SERVICE_ENTITY = "NAVIGATOR_SERVICE_ENTITY";
        private const string FieldNAVIGATOR_SUPPORT_ENTITY = "NAVIGATOR_SUPPORT_ENTITY";
        private const string FieldNAVIGATOR_WORKTICKET_ENTITY = "NAVIGATOR_WORKTICKET_ENTITY";
        private const string FieldNAVIGATOR_TASK_ENTITY = "NAVIGATOR_TASK_ENTITY";
        private const string FieldNAVIGATOR_SUPPORT_TASK_ENTITY = "NAVIGATOR_SUPPORT_TASK_ENTITY";
        private const string FieldNAVIGATOR_SERVICE_TASK_ENTITY = "NAVIGATOR_SERVICE_TASK_ENTITY";
        private const string FieldNAVIGATOR_SALES_TASK_ENTITY = "NAVIGATOR_SALES_TASK_ENTITY";
        private const string FieldNAVIGATOR_FORECAST_ENTITY = "NAVIGATOR_FORECAST_ENTITY";
        private const string FieldNAVIGATOR_EMAIL_ENTITY = "NAVIGATOR_EMAIL_ENTITY";
        private const string FieldNAVIGATOR_PRODUCT_ENTITY = "NAVIGATOR_PRODUCT_ENTITY";
        private const string FieldNAVIGATOR_APPOINTMENT_ENTITY = "NAVIGATOR_APPOINTMENT_ENTITY";
        private const string FieldNAVIGATOR_SCRIPT_ENTITY = "NAVIGATOR_SCRIPT_ENTITY";
        private const string FieldPREFERENCE_NAME = "PREFERENCE_NAME";
        private const string FieldSUCCESS_MESSAGE = "SUCCESS_MESSAGE";
        private const string FieldSUCCESS_MESSAGE_WITHINFO = "SUCCESS_MESSAGE_WITHINFO";
        private const string FieldEXCEPTION_MESSAGE = "EXCEPTION_MESSAGE";
        private const string FieldEXCEPTION_MESSAGE_NOTITLE = "EXCEPTION_MESSAGE_NOTITLE";
        private const string FieldQUERY_PROFILE_XML = "QUERY_PROFILE_XML";
        private const string FieldEXCEPTION_NOQUERYCONFIGATION = "EXCEPTION_NOQUERYCONFIGATION";
        private const string FieldLboId = "LboId";
        private const string FieldLboMethod = "LboMethod";
        private const string FieldPassword = "Password";
        private const string FieldNewPassword = "NewPassword";
        private const string FieldAuthMode = "AuthMode";
        private const string FieldWidth = "Width";
        private const string FieldResourceAssemblyName = "ResourceAssemblyName";
        private const string FieldMENUITEM_ID = "MENUITEM_ID";
        private const string FieldENTITY_NAME = "ENTITY_NAME";
        private const string FieldUNIQUE_ID = "UNIQUE_ID";
        private const string FieldNOTIFICATION_SUBSCRIPTION_ID = "NOTIFICATION_SUBSCRIPTION_ID";
        private const string FieldSUBSCRIPTION_TYPE = "SUBSCRIPTION_TYPE";

        #endregion

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetUserIdFromSession, 0)]
        [TestCase(MethodGetFirstDayOfWeek, 0)]
        [TestCase(MethodGetFirstDayOfMonth, 0)]
        [TestCase(MethodGetFirstDayOfQuarter, 0)]
        [TestCase(MethodGetFirstDayOfYear, 0)]
        [TestCase(MethodGetMessage, 0)]
        [TestCase(MethodGetNodeValue, 0)]
        [TestCase(MethodSetNodeValue, 0)]
        [TestCase(MethodGetRelativePath, 0)]
        [TestCase(MethodDecryptText, 0)]
        [TestCase(MethodDecryptConnectionString, 0)]
        [TestCase(MethodMergeConfigXml, 0)]
        [TestCase(MethodMergeConfigXml, 1)]
        [TestCase(MethodSafeGetFromHashTables, 0)]
        [TestCase(MethodGetErrorMessageFromResourceAssembly, 0)]
        [TestCase(MethodExecuteQuery, 0)]
        [TestCase(MethodExecuteLboMethod, 0)]
        [TestCase(MethodSortByAttribute, 0)]
        [TestCase(MethodgetIndividualNamingFormat, 0)]
        [TestCase(MethodgetIndividualName, 0)]
        [TestCase(MethodaddNode, 0)]
        [TestCase(MethodIgnoreXmlComments, 0)]
        [TestCase(MethodBatchUpdateMapping, 0)]
        [TestCase(MethodGetContextData, 0)]
        [TestCase(MethodGetLocalXMLString, 0)]
        [TestCase(MethodGetMobileProfileName, 0)]
        [TestCase(MethodGetOwnerTypeForMobile, 0)]
        [TestCase(MethodGetEntityNameForMobile, 0)]
        public void AUT_Common_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Common) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldLBO_OBJECT_WATCH)]
        [TestCase(FieldLBO_METHOD_WATCH_INSERTUPDATE)]
        [TestCase(FieldLBO_METHOD_RETRIEVELISTBY_USERID)]
        [TestCase(FieldLBO_INCIDENT_EVENT_DATA)]
        [TestCase(FieldXPATH_DETAILS_TEMPLATE_IDS)]
        [TestCase(FieldXPATH_LIST_TEMPLATE_IDS)]
        [TestCase(FieldXPATH_METADATA_TEMPLATE_IDS)]
        [TestCase(FieldXPATH_DETAILS_PROFILE_COLUMNAMES)]
        [TestCase(FieldXPATH_LIST_PROFILE_COLUMNAMES)]
        [TestCase(FieldXPATH_LIST_PROFILE_GROUPS)]
        [TestCase(FieldXPATH_LBORESULT_COLUMN_DEFINTIONS)]
        [TestCase(FieldMENUID)]
        [TestCase(FieldWATCH_RETRIEVELIST_USERID_PARAM_XML)]
        [TestCase(FieldWATCH_INSERTUPDATE_PARAM_XML)]
        [TestCase(FieldRETRIVE_PARAM_XML)]
        [TestCase(FieldRESULT_GRID_DEFAULT_MIN_ROWS)]
        [TestCase(FieldPARAMETER_DELIMITER)]
        [TestCase(FieldMULTIPLE_PARAMETER_DELIMITER)]
        [TestCase(FieldSQL_WHERE)]
        [TestCase(FieldSQL_AND)]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldNAVIGATOR_ENTITY_ID)]
        [TestCase(FieldFIELD_ID)]
        [TestCase(FieldDISPLAY_NAME)]
        [TestCase(FieldSEQUENCE_INDEX)]
        [TestCase(FieldIS_EDITABLE)]
        [TestCase(FieldFIELD_STATE)]
        [TestCase(FieldMAX_RECORDS)]
        [TestCase(FieldSORT_ORDER)]
        [TestCase(FieldSORT_BY)]
        [TestCase(FieldSORT_TYPE)]
        [TestCase(FieldCONTENT)]
        [TestCase(FieldUI_RESOURCE)]
        [TestCase(FieldIS_REQUIRED)]
        [TestCase(FieldPARAMETER)]
        [TestCase(FieldPARAMETERS)]
        [TestCase(FieldMODE)]
        [TestCase(FieldCREDENTIAL)]
        [TestCase(FieldAPPLICATION_NAME)]
        [TestCase(FieldSITE_ID)]
        [TestCase(FieldLANG_CODE)]
        [TestCase(FieldREQUEST_TO_QAS)]
        [TestCase(FieldQUERY_ID)]
        [TestCase(FieldQUERY_NAME)]
        [TestCase(FieldQUERY_TYPE)]
        [TestCase(FieldQUERY_MODE)]
        [TestCase(FieldPROTECTION_MODE)]
        [TestCase(FieldQUERY_PARAMETER)]
        [TestCase(FieldGROUP)]
        [TestCase(FieldIS_BOOKMARK)]
        [TestCase(FieldIS_HOME_PAGE_QUERY)]
        [TestCase(FieldFOLDER_NAME)]
        [TestCase(FieldPARENT_FOLDER_ID)]
        [TestCase(FieldFOLDER_ID)]
        [TestCase(FieldPUBLIC_FOLDER_ID)]
        [TestCase(FieldPERSONAL_FOLDER_ID)]
        [TestCase(FieldCOUNTRY_ID)]
        [TestCase(FieldPARENT_ID)]
        [TestCase(FieldIS_MOBILEBOOKMARK)]
        [TestCase(FieldWATCH)]
        [TestCase(FieldCLIENT_DATETIME)]
        [TestCase(FieldCLIENT_UTC_OFFSET)]
        [TestCase(FieldPAGE_INDEX)]
        [TestCase(FieldAPP_ID)]
        [TestCase(FieldAPP_KEY)]
        [TestCase(FieldSEARCH_STRING)]
        [TestCase(FieldUSER_ID)]
        [TestCase(FieldORIGINAL_USER_ID)]
        [TestCase(FieldCONTENT_TYPE)]
        [TestCase(FieldACTION)]
        [TestCase(FieldTRANSACTION_CREATE)]
        [TestCase(FieldTRANSACTION_APPEND)]
        [TestCase(FieldTRANSACTION_UPDATE)]
        [TestCase(FieldTRANSACTION_DELETE)]
        [TestCase(FieldTRANSACTION_RENAME)]
        [TestCase(FieldSearch_type)]
        [TestCase(FieldLBO_NAME)]
        [TestCase(FieldLBO_Method)]
        [TestCase(FieldLBO_METHOD_NAME)]
        [TestCase(FieldLBO_OBJECT_NAME)]
        [TestCase(FieldTIME_STAMP)]
        [TestCase(FieldPRIMARY_ID)]
        [TestCase(FieldOWNER_ID)]
        [TestCase(FieldOWNER_TYPE)]
        [TestCase(FieldCATEGORY_ID)]
        [TestCase(FieldGROUP_TYPE_ID)]
        [TestCase(FieldACTIVE)]
        [TestCase(FieldcallFrom)]
        [TestCase(FieldSTATUS_ID)]
        [TestCase(FieldFILENAME)]
        [TestCase(FieldEXTENSION)]
        [TestCase(FieldprofileName)]
        [TestCase(FieldREMINDER_PRIMARY_ID)]
        [TestCase(FieldREMINDER_RECALL_TIME)]
        [TestCase(FieldREMINDER_RECALL_DATE)]
        [TestCase(FieldPHONE_PRIMARY_ID)]
        [TestCase(FieldPHONE_TIME_STAMP)]
        [TestCase(FieldPHONE_NUMBER)]
        [TestCase(FieldPHONE_TYPE)]
        [TestCase(FieldPHONE_OWNER_ID)]
        [TestCase(FieldPHONE_OWNER_TYPE)]
        [TestCase(FieldADDRESS_PRIMARY_ID)]
        [TestCase(FieldADDRESS_TIME_STAMP)]
        [TestCase(FieldADDRESS_CITY)]
        [TestCase(FieldADDRESS_STATE)]
        [TestCase(FieldADDRESS_COUNTRY)]
        [TestCase(FieldADDRESS_POSTAL_CODE)]
        [TestCase(FieldADDRESS_OWNER_ID)]
        [TestCase(FieldADDRESS_OWNER_TYPE)]
        [TestCase(FieldCOMPANY_CONTACT_FIRST_NAME)]
        [TestCase(FieldCOMPANY_CONTACT_LAST_NAME)]
        [TestCase(FieldINDIVIDUAL_FIRST_NAME)]
        [TestCase(FieldINDIVIDUAL_LAST_NAME)]
        [TestCase(FieldINCIDENT_OWNER_ID)]
        [TestCase(FieldINCIDENT_OWNER_TYPE)]
        [TestCase(FieldINCIDENT_CATEGORY_ID)]
        [TestCase(FieldINCIDENT_CONTACT_FIRST_NAME)]
        [TestCase(FieldINCIDENT_CONTACT_LAST_NAME)]
        [TestCase(FieldINCIDENT_OWNER_TIMESTAMP)]
        [TestCase(FieldREMINDER_OWNER_ID)]
        [TestCase(FieldREMINDER_OWNER_TYPE)]
        [TestCase(FieldREMINDER_DUEBY)]
        [TestCase(FieldPARENT_GROUP_ID)]
        [TestCase(FieldCONTACT_ID)]
        [TestCase(FieldCONTACT_TYPE_ID)]
        [TestCase(FieldOBJECT_TYPE_ID)]
        [TestCase(FieldTAGS_CATEGORY_ID)]
        [TestCase(FieldTAGS_OBJECT_TYPE_ENUM)]
        [TestCase(FieldSOURCE_PRIMARY_ID)]
        [TestCase(FieldTARGET_PRIMARY_ID)]
        [TestCase(FieldEXCEPTION_HANDLE)]
        [TestCase(FieldPARAM_XML)]
        [TestCase(FieldCUSTOM_XML)]
        [TestCase(FieldRESOURCE_ID)]
        [TestCase(FieldTWITTER_SCREEN_NAME)]
        [TestCase(FieldAPPLICATION_TYPE)]
        [TestCase(FieldMobileUserLoginPermission)]
        [TestCase(FieldEMFUserLoginPermission)]
        [TestCase(FieldAnalyticsLoginPermission)]
        [TestCase(FieldOEPLoginPermission)]
        [TestCase(FieldRlcAdministrationResource)]
        [TestCase(FieldRESOURCE_SEARCH_FILTER_ADMINISTRATION)]
        [TestCase(FieldRESOURCE_RLC_DISABLED_LIST)]
        [TestCase(FieldRESOURCE_RLC_AVAILABLE_LIST)]
        [TestCase(FieldRESOURCE_RLC_HEADER_LIST)]
        [TestCase(FieldDefaultSearchFilterList)]
        [TestCase(FieldAvailableSearchFilterList)]
        [TestCase(FieldDisabledSearchFilterList)]
        [TestCase(FieldQUERY_EXPLORER_SHOW_PUBLIC_FOLDER)]
        [TestCase(FieldMODULE_ID)]
        [TestCase(FieldPLP_TOKEN)]
        [TestCase(FieldPROFILE_ID)]
        [TestCase(FieldTIME_ZONE_OFFSET)]
        [TestCase(FieldREQUEST_FOR_DOCK_QUERY)]
        [TestCase(FieldInActivePlpToken)]
        [TestCase(FieldDATA_TYPE_DATETIME)]
        [TestCase(FieldDATA_TYPE_ENUM_INTEGER)]
        [TestCase(FieldDATA_TYPE_INTEGER)]
        [TestCase(FieldDATA_TYPE_FLOAT)]
        [TestCase(FieldDATA_TYPE_BIT)]
        [TestCase(FieldFORMAT_DATE)]
        [TestCase(FieldFORMAT_DATE_TIME)]
        [TestCase(FieldFORMAT_STARTDATE24)]
        [TestCase(FieldFORMAT_ENDDATE24)]
        [TestCase(FieldFORMAT_DATE_TIME24_STRING)]
        [TestCase(FieldFORMAT_DATE_TIME24)]
        [TestCase(FieldSQLFORMAT_DATE_TIME24)]
        [TestCase(FieldFORMAT_LOGICAL_EXPRESSION_BETWEEN)]
        [TestCase(FieldMASK_DELIMITER)]
        [TestCase(FieldLOG_NAME)]
        [TestCase(FieldLOG_SOURCE_NAME)]
        [TestCase(FieldLOG_LEVEL)]
        [TestCase(FieldFORMAT_EXCEPTION_METHOD)]
        [TestCase(FieldEMF_KEY)]
        [TestCase(FieldNAVIGATOR_COMPANY_ENTITY)]
        [TestCase(FieldNAVIGATOR_INDIVIDUAL_ENTITY)]
        [TestCase(FieldNAVIGATOR_SALES_ENTITY)]
        [TestCase(FieldNAVIGATOR_SERVICE_ENTITY)]
        [TestCase(FieldNAVIGATOR_SUPPORT_ENTITY)]
        [TestCase(FieldNAVIGATOR_WORKTICKET_ENTITY)]
        [TestCase(FieldNAVIGATOR_TASK_ENTITY)]
        [TestCase(FieldNAVIGATOR_SUPPORT_TASK_ENTITY)]
        [TestCase(FieldNAVIGATOR_SERVICE_TASK_ENTITY)]
        [TestCase(FieldNAVIGATOR_SALES_TASK_ENTITY)]
        [TestCase(FieldNAVIGATOR_FORECAST_ENTITY)]
        [TestCase(FieldNAVIGATOR_EMAIL_ENTITY)]
        [TestCase(FieldNAVIGATOR_PRODUCT_ENTITY)]
        [TestCase(FieldNAVIGATOR_APPOINTMENT_ENTITY)]
        [TestCase(FieldNAVIGATOR_SCRIPT_ENTITY)]
        [TestCase(FieldPREFERENCE_NAME)]
        [TestCase(FieldSUCCESS_MESSAGE)]
        [TestCase(FieldSUCCESS_MESSAGE_WITHINFO)]
        [TestCase(FieldEXCEPTION_MESSAGE)]
        [TestCase(FieldEXCEPTION_MESSAGE_NOTITLE)]
        [TestCase(FieldQUERY_PROFILE_XML)]
        [TestCase(FieldEXCEPTION_NOQUERYCONFIGATION)]
        [TestCase(FieldLboId)]
        [TestCase(FieldLboMethod)]
        [TestCase(FieldPassword)]
        [TestCase(FieldNewPassword)]
        [TestCase(FieldAuthMode)]
        [TestCase(FieldWidth)]
        [TestCase(FieldResourceAssemblyName)]
        [TestCase(FieldMENUITEM_ID)]
        [TestCase(FieldENTITY_NAME)]
        [TestCase(FieldUNIQUE_ID)]
        [TestCase(FieldNOTIFICATION_SUBSCRIPTION_ID)]
        [TestCase(FieldSUBSCRIPTION_TYPE)]
        [Category("AUT Fields")]
        public void AUT_Common_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Common) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Common" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetUserIdFromSession) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetUserIdFromSession_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserIdFromSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetUserIdFromSession(sessionId, appName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetUserIdFromSession(sessionId, appName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var methodGetUserIdFromSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUserIdFromSession = { sessionId, appName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetUserIdFromSession, parametersOfGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserIdFromSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserIdFromSession.ShouldNotBeNull();
            parametersOfGetUserIdFromSession.Length.ShouldBe(2);
            methodGetUserIdFromSessionParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var methodGetUserIdFromSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUserIdFromSession = { sessionId, appName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUserIdFromSession, parametersOfGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes);

            // Assert
            parametersOfGetUserIdFromSession.ShouldNotBeNull();
            parametersOfGetUserIdFromSession.Length.ShouldBe(2);
            methodGetUserIdFromSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var methodGetUserIdFromSessionParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserIdFromSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var methodGetUserIdFromSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserIdFromSession, methodGetUserIdFromSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserIdFromSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserIdFromSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserIdFromSession) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserIdFromSession_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserIdFromSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserIdFromSession, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfWeekParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Common.GetFirstDayOfWeek(dateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = Common.GetFirstDayOfWeek(dateTime);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfWeek = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfWeek, parametersOfGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.Length.ShouldBe(1);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfWeek, parametersOfGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfWeek = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfWeek);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfWeek.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.Length.ShouldBe(1);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfWeek = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfWeek, parametersOfGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            parametersOfGetFirstDayOfWeek.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.Length.ShouldBe(1);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfWeek_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfMonthParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Common.GetFirstDayOfMonth(dateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = Common.GetFirstDayOfMonth(dateTime);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfMonth = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfMonth, parametersOfGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.Length.ShouldBe(1);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfMonth, parametersOfGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfMonth = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfMonth);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfMonth.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.Length.ShouldBe(1);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfMonth = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfMonth, parametersOfGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            parametersOfGetFirstDayOfMonth.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.Length.ShouldBe(1);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfMonth_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfQuarterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Common.GetFirstDayOfQuarter(dateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = Common.GetFirstDayOfQuarter(dateTime);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfQuarter = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfQuarter, parametersOfGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.Length.ShouldBe(1);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfQuarter, parametersOfGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfQuarter = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfQuarter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfQuarter.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.Length.ShouldBe(1);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfQuarter = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfQuarter, parametersOfGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            parametersOfGetFirstDayOfQuarter.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.Length.ShouldBe(1);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfQuarter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetFirstDayOfYear_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfYearParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Common.GetFirstDayOfYear(dateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = Common.GetFirstDayOfYear(dateTime);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfYear = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfYear, parametersOfGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.Length.ShouldBe(1);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfYear, parametersOfGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfYear = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfYear);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfYear.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.Length.ShouldBe(1);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfYear = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfYear, parametersOfGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            parametersOfGetFirstDayOfYear.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.Length.ShouldBe(1);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFirstDayOfYear_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetMessage_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);

            // Act
            Action executeAction = () => Common.GetMessage();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetMessage();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            Type [] methodGetMessageParametersTypes = null;
            object[] parametersOfGetMessage = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, methodGetMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetMessage, parametersOfGetMessage, methodGetMessageParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMessage.ShouldBeNull();
            methodGetMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetMessage, parametersOfGetMessage, methodGetMessageParametersTypes));
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            Type [] methodGetMessageParametersTypes = null;
            object[] parametersOfGetMessage = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, methodGetMessageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMessage.ShouldBeNull();
            methodGetMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            Type [] methodGetMessageParametersTypes = null;
            object[] parametersOfGetMessage = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMessage, parametersOfGetMessage, methodGetMessageParametersTypes);

            // Assert
            parametersOfGetMessage.ShouldBeNull();
            methodGetMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            Type [] methodGetMessageParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            Type [] methodGetMessageParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetNodeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetNodeValue(stringXml, nodePath);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetNodeValue(stringXml, nodePath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetNodeValue = { stringXml, nodePath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, methodGetNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(2);
            methodGetNodeValueParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetNodeValue = { stringXml, nodePath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(2);
            methodGetNodeValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNodeValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetNodeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_SetNodeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetNodeValue, methodSetNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var nodeValue = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.SetNodeValue(stringXml, nodePath, nodeValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var nodeValue = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.SetNodeValue(stringXml, nodePath, nodeValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var nodeValue = this.CreateType<string>();
            var methodSetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSetNodeValue = { stringXml, nodePath, nodeValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetNodeValue, methodSetNodeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSetNodeValue, methodSetNodeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodSetNodeValue, parametersOfSetNodeValue, methodSetNodeValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSetNodeValue.ShouldNotBeNull();
            parametersOfSetNodeValue.Length.ShouldBe(3);
            methodSetNodeValueParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var stringXml = this.CreateType<string>();
            var nodePath = this.CreateType<string>();
            var nodeValue = this.CreateType<string>();
            var methodSetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSetNodeValue = { stringXml, nodePath, nodeValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSetNodeValue, parametersOfSetNodeValue, methodSetNodeValueParametersTypes);

            // Assert
            parametersOfSetNodeValue.ShouldNotBeNull();
            parametersOfSetNodeValue.Length.ShouldBe(3);
            methodSetNodeValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var methodSetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetNodeValue, methodSetNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSetNodeValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var methodSetNodeValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetNodeValue, methodSetNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SetNodeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSetNodeValue, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetRelativePath_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRelativePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetRelativePath(fileName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetRelativePath(fileName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, methodGetRelativePathParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetRelativePath, parametersOfGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRelativePath.ShouldNotBeNull();
            parametersOfGetRelativePath.Length.ShouldBe(1);
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetRelativePath, parametersOfGetRelativePath, methodGetRelativePathParametersTypes));
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, methodGetRelativePathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRelativePath);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRelativePath.ShouldNotBeNull();
            parametersOfGetRelativePath.Length.ShouldBe(1);
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var fileName = this.CreateType<string>();
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRelativePath = { fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRelativePath, parametersOfGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            parametersOfGetRelativePath.ShouldNotBeNull();
            parametersOfGetRelativePath.Length.ShouldBe(1);
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRelativePathParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var methodGetRelativePathParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRelativePath, methodGetRelativePathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRelativePathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRelativePath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRelativePath_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRelativePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRelativePath, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_DecryptText_Static_Method_Call_Internally(Type[] types)
        {
            var methodDecryptTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.DecryptText(encryptedText);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.DecryptText(encryptedText);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptText = { encryptedText };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, methodDecryptTextParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDecryptText, parametersOfDecryptText, methodDecryptTextParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDecryptText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDecryptText.ShouldNotBeNull();
            parametersOfDecryptText.Length.ShouldBe(1);
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptText = { encryptedText };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecryptText, parametersOfDecryptText, methodDecryptTextParametersTypes);

            // Assert
            parametersOfDecryptText.ShouldNotBeNull();
            parametersOfDecryptText.Length.ShouldBe(1);
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_DecryptConnectionString_Static_Method_Call_Internally(Type[] types)
        {
            var methodDecryptConnectionStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecryptConnectionString, methodDecryptConnectionStringParametersTypes);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var connectionStringName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.DecryptConnectionString(connectionStringName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var connectionStringName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.DecryptConnectionString(connectionStringName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var connectionStringName = this.CreateType<string>();
            var methodDecryptConnectionStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptConnectionString = { connectionStringName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptConnectionString, methodDecryptConnectionStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDecryptConnectionString, methodDecryptConnectionStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDecryptConnectionString, parametersOfDecryptConnectionString, methodDecryptConnectionStringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDecryptConnectionString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDecryptConnectionString.ShouldNotBeNull();
            parametersOfDecryptConnectionString.Length.ShouldBe(1);
            methodDecryptConnectionStringParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var connectionStringName = this.CreateType<string>();
            var methodDecryptConnectionStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptConnectionString = { connectionStringName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecryptConnectionString, parametersOfDecryptConnectionString, methodDecryptConnectionStringParametersTypes);

            // Assert
            parametersOfDecryptConnectionString.ShouldNotBeNull();
            parametersOfDecryptConnectionString.Length.ShouldBe(1);
            methodDecryptConnectionStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var methodDecryptConnectionStringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecryptConnectionString, methodDecryptConnectionStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDecryptConnectionStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var methodDecryptConnectionStringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecryptConnectionString, methodDecryptConnectionStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptConnectionStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptConnectionString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptConnectionString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptConnectionString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptConnectionString);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptConnectionString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_MergeConfigXml_Static_Method_Call_Internally(Type[] types)
        {
            var methodMergeConfigXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var entityName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => Common.MergeConfigXml(searchResultXml, entityName, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var entityName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.MergeConfigXml(searchResultXml, entityName, parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var entityName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfMergeConfigXml = { searchResultXml, entityName, parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodMergeConfigXml, parametersOfMergeConfigXml, methodMergeConfigXmlParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfMergeConfigXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMergeConfigXml.ShouldNotBeNull();
            parametersOfMergeConfigXml.Length.ShouldBe(3);
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var entityName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfMergeConfigXml = { searchResultXml, entityName, parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMergeConfigXml, parametersOfMergeConfigXml, methodMergeConfigXmlParametersTypes);

            // Assert
            parametersOfMergeConfigXml.ShouldNotBeNull();
            parametersOfMergeConfigXml.Length.ShouldBe(3);
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeConfigXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeConfigXml, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_MergeConfigXml_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodMergeConfigXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var configXml = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.MergeConfigXml(searchResultXml, configXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var configXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.MergeConfigXml(searchResultXml, configXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var configXml = this.CreateType<string>();
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfMergeConfigXml = { searchResultXml, configXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodMergeConfigXml, parametersOfMergeConfigXml, methodMergeConfigXmlParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfMergeConfigXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMergeConfigXml.ShouldNotBeNull();
            parametersOfMergeConfigXml.Length.ShouldBe(2);
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var searchResultXml = this.CreateType<string>();
            var configXml = this.CreateType<string>();
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfMergeConfigXml = { searchResultXml, configXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMergeConfigXml, parametersOfMergeConfigXml, methodMergeConfigXmlParametersTypes);

            // Assert
            parametersOfMergeConfigXml.ShouldNotBeNull();
            parametersOfMergeConfigXml.Length.ShouldBe(2);
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var methodMergeConfigXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeConfigXml, methodMergeConfigXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeConfigXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeConfigXml, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeConfigXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_MergeConfigXml_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeConfigXml);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeConfigXml, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_SafeGetFromHashTables_Static_Method_Call_Internally(Type[] types)
        {
            var methodSafeGetFromHashTablesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var hashTable = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.SafeGetFromHashTables(hashTable, key);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var hashTable = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.SafeGetFromHashTables(hashTable, key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var hashTable = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var methodSafeGetFromHashTablesParametersTypes = new Type[] { typeof(Hashtable), typeof(string) };
            object[] parametersOfSafeGetFromHashTables = { hashTable, key };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodSafeGetFromHashTables, parametersOfSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSafeGetFromHashTables.ShouldNotBeNull();
            parametersOfSafeGetFromHashTables.Length.ShouldBe(2);
            methodSafeGetFromHashTablesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodSafeGetFromHashTables, parametersOfSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes));
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var hashTable = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var methodSafeGetFromHashTablesParametersTypes = new Type[] { typeof(Hashtable), typeof(string) };
            object[] parametersOfSafeGetFromHashTables = { hashTable, key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSafeGetFromHashTables);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSafeGetFromHashTables.ShouldNotBeNull();
            parametersOfSafeGetFromHashTables.Length.ShouldBe(2);
            methodSafeGetFromHashTablesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var hashTable = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var methodSafeGetFromHashTablesParametersTypes = new Type[] { typeof(Hashtable), typeof(string) };
            object[] parametersOfSafeGetFromHashTables = { hashTable, key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSafeGetFromHashTables, parametersOfSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes);

            // Assert
            parametersOfSafeGetFromHashTables.ShouldNotBeNull();
            parametersOfSafeGetFromHashTables.Length.ShouldBe(2);
            methodSafeGetFromHashTablesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var methodSafeGetFromHashTablesParametersTypes = new Type[] { typeof(Hashtable), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSafeGetFromHashTablesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var methodSafeGetFromHashTablesParametersTypes = new Type[] { typeof(Hashtable), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSafeGetFromHashTables, methodSafeGetFromHashTablesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSafeGetFromHashTablesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var currentMethodInfo = this.GetMethodInfo(MethodSafeGetFromHashTables, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SafeGetFromHashTables) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeGetFromHashTables_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeGetFromHashTables);
            var currentMethodInfo = this.GetMethodInfo(MethodSafeGetFromHashTables, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetErrorMessageFromResourceAssemblyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetErrorMessageFromResourceAssembly, methodGetErrorMessageFromResourceAssemblyParametersTypes);
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorMessageFromResourceAssembly);
            var languageCode = this.CreateType<string>();
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetErrorMessageFromResourceAssembly(languageCode, key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorMessageFromResourceAssembly);
            var languageCode = this.CreateType<string>();
            var key = this.CreateType<string>();
            var methodGetErrorMessageFromResourceAssemblyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetErrorMessageFromResourceAssembly = { languageCode, key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetErrorMessageFromResourceAssembly, parametersOfGetErrorMessageFromResourceAssembly, methodGetErrorMessageFromResourceAssemblyParametersTypes);

            // Assert
            parametersOfGetErrorMessageFromResourceAssembly.ShouldNotBeNull();
            parametersOfGetErrorMessageFromResourceAssembly.Length.ShouldBe(2);
            methodGetErrorMessageFromResourceAssemblyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorMessageFromResourceAssembly);
            var methodGetErrorMessageFromResourceAssemblyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetErrorMessageFromResourceAssembly, methodGetErrorMessageFromResourceAssemblyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetErrorMessageFromResourceAssemblyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorMessageFromResourceAssembly);
            var methodGetErrorMessageFromResourceAssemblyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetErrorMessageFromResourceAssembly, methodGetErrorMessageFromResourceAssemblyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetErrorMessageFromResourceAssemblyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorMessageFromResourceAssembly);
            var currentMethodInfo = this.GetMethodInfo(MethodGetErrorMessageFromResourceAssembly, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetErrorMessageFromResourceAssembly) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetErrorMessageFromResourceAssembly_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorMessageFromResourceAssembly);
            var currentMethodInfo = this.GetMethodInfo(MethodGetErrorMessageFromResourceAssembly, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_ExecuteQuery_Static_Method_Call_Internally(Type[] types)
        {
            var methodExecuteQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteQuery, methodExecuteQueryParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.ExecuteQuery(applicationName, sessionId, paramXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.ExecuteQuery(applicationName, sessionId, paramXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var methodExecuteQueryParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecuteQuery = { applicationName, sessionId, paramXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteQuery, methodExecuteQueryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodExecuteQuery, methodExecuteQueryParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodExecuteQuery, parametersOfExecuteQuery, methodExecuteQueryParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfExecuteQuery);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteQuery.ShouldNotBeNull();
            parametersOfExecuteQuery.Length.ShouldBe(3);
            methodExecuteQueryParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var methodExecuteQueryParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecuteQuery = { applicationName, sessionId, paramXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecuteQuery, parametersOfExecuteQuery, methodExecuteQueryParametersTypes);

            // Assert
            parametersOfExecuteQuery.ShouldNotBeNull();
            parametersOfExecuteQuery.Length.ShouldBe(3);
            methodExecuteQueryParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var methodExecuteQueryParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteQuery, methodExecuteQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteQueryParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var methodExecuteQueryParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteQuery, methodExecuteQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteQuery) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteQuery_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteQuery, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_ExecuteLboMethod_Static_Method_Call_Internally(Type[] types)
        {
            var methodExecuteLboMethodParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteLboMethod, methodExecuteLboMethodParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var lboObject = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var paramXml = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.ExecuteLboMethod(applicationName, sessionId, lboObject, lboMethod, paramXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var lboObject = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.ExecuteLboMethod(applicationName, sessionId, lboObject, lboMethod, paramXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var lboObject = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var methodExecuteLboMethodParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecuteLboMethod = { applicationName, sessionId, lboObject, lboMethod, paramXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLboMethod, methodExecuteLboMethodParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodExecuteLboMethod, methodExecuteLboMethodParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodExecuteLboMethod, parametersOfExecuteLboMethod, methodExecuteLboMethodParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfExecuteLboMethod);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteLboMethod.ShouldNotBeNull();
            parametersOfExecuteLboMethod.Length.ShouldBe(5);
            methodExecuteLboMethodParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var applicationName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var lboObject = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var methodExecuteLboMethodParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecuteLboMethod = { applicationName, sessionId, lboObject, lboMethod, paramXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecuteLboMethod, parametersOfExecuteLboMethod, methodExecuteLboMethodParametersTypes);

            // Assert
            parametersOfExecuteLboMethod.ShouldNotBeNull();
            parametersOfExecuteLboMethod.Length.ShouldBe(5);
            methodExecuteLboMethodParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var methodExecuteLboMethodParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteLboMethod, methodExecuteLboMethodParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteLboMethodParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var methodExecuteLboMethodParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteLboMethod, methodExecuteLboMethodParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteLboMethodParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLboMethod, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLboMethod) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ExecuteLboMethod_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLboMethod);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLboMethod, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_SortByAttribute_Static_Method_Call_Internally(Type[] types)
        {
            var methodSortByAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSortByAttribute, methodSortByAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var nodePath = this.CreateType<string>();
            var attributeName = this.CreateType<string>();
            var isNumeric = this.CreateType<bool>();
            var isAscending = this.CreateType<bool>();

            // Act
            Action executeAction = () => Common.SortByAttribute(xmlDoc, nodePath, attributeName, isNumeric, isAscending);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var nodePath = this.CreateType<string>();
            var attributeName = this.CreateType<string>();
            var isNumeric = this.CreateType<bool>();
            var isAscending = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.SortByAttribute(xmlDoc, nodePath, attributeName, isNumeric, isAscending);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var nodePath = this.CreateType<string>();
            var attributeName = this.CreateType<string>();
            var isNumeric = this.CreateType<bool>();
            var isAscending = this.CreateType<bool>();
            var methodSortByAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfSortByAttribute = { xmlDoc, nodePath, attributeName, isNumeric, isAscending };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSortByAttribute, methodSortByAttributeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSortByAttribute, methodSortByAttributeParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodSortByAttribute, parametersOfSortByAttribute, methodSortByAttributeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSortByAttribute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSortByAttribute.ShouldNotBeNull();
            parametersOfSortByAttribute.Length.ShouldBe(5);
            methodSortByAttributeParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var xmlDoc = this.CreateType<XmlDocument>();
            var nodePath = this.CreateType<string>();
            var attributeName = this.CreateType<string>();
            var isNumeric = this.CreateType<bool>();
            var isAscending = this.CreateType<bool>();
            var methodSortByAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfSortByAttribute = { xmlDoc, nodePath, attributeName, isNumeric, isAscending };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSortByAttribute, parametersOfSortByAttribute, methodSortByAttributeParametersTypes);

            // Assert
            parametersOfSortByAttribute.ShouldNotBeNull();
            parametersOfSortByAttribute.Length.ShouldBe(5);
            methodSortByAttributeParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var methodSortByAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string), typeof(bool), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSortByAttribute, methodSortByAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSortByAttributeParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var methodSortByAttributeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSortByAttribute, methodSortByAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSortByAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodSortByAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SortByAttribute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SortByAttribute_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortByAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodSortByAttribute, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_getIndividualNamingFormat_Static_Method_Call_Internally(Type[] types)
        {
            var methodgetIndividualNamingFormatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetIndividualNamingFormat, methodgetIndividualNamingFormatParametersTypes);
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var langCode = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.getIndividualNamingFormat(langCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var langCode = this.CreateType<string>();
            var returnedValue = default(IndividualNamingFormat);

            // Act
            Action executeAction = () => returnedValue = Common.getIndividualNamingFormat(langCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var langCode = this.CreateType<string>();
            var methodgetIndividualNamingFormatParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfgetIndividualNamingFormat = { langCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IndividualNamingFormat>(MethodgetIndividualNamingFormat, parametersOfgetIndividualNamingFormat, methodgetIndividualNamingFormatParametersTypes);

            // Assert
            parametersOfgetIndividualNamingFormat.ShouldNotBeNull();
            parametersOfgetIndividualNamingFormat.Length.ShouldBe(1);
            methodgetIndividualNamingFormatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var methodgetIndividualNamingFormatParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetIndividualNamingFormat, methodgetIndividualNamingFormatParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetIndividualNamingFormatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var methodgetIndividualNamingFormatParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetIndividualNamingFormat, methodgetIndividualNamingFormatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetIndividualNamingFormatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodgetIndividualNamingFormat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getIndividualNamingFormat) (Return Type : IndividualNamingFormat) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualNamingFormat_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualNamingFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodgetIndividualNamingFormat, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_getIndividualName_Static_Method_Call_Internally(Type[] types)
        {
            var methodgetIndividualNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetIndividualName, methodgetIndividualNameParametersTypes);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var format = this.CreateType<IndividualNamingFormat>();
            var firstName = this.CreateType<string>();
            var middleName = this.CreateType<string>();
            var lastName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.getIndividualName(format, firstName, middleName, lastName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var format = this.CreateType<IndividualNamingFormat>();
            var firstName = this.CreateType<string>();
            var middleName = this.CreateType<string>();
            var lastName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.getIndividualName(format, firstName, middleName, lastName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var format = this.CreateType<IndividualNamingFormat>();
            var firstName = this.CreateType<string>();
            var middleName = this.CreateType<string>();
            var lastName = this.CreateType<string>();
            var methodgetIndividualNameParametersTypes = new Type[] { typeof(IndividualNamingFormat), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfgetIndividualName = { format, firstName, middleName, lastName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetIndividualName, methodgetIndividualNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodgetIndividualName, methodgetIndividualNameParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodgetIndividualName, parametersOfgetIndividualName, methodgetIndividualNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfgetIndividualName.ShouldNotBeNull();
            parametersOfgetIndividualName.Length.ShouldBe(4);
            methodgetIndividualNameParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodgetIndividualName, parametersOfgetIndividualName, methodgetIndividualNameParametersTypes));
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var format = this.CreateType<IndividualNamingFormat>();
            var firstName = this.CreateType<string>();
            var middleName = this.CreateType<string>();
            var lastName = this.CreateType<string>();
            var methodgetIndividualNameParametersTypes = new Type[] { typeof(IndividualNamingFormat), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfgetIndividualName = { format, firstName, middleName, lastName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodgetIndividualName, methodgetIndividualNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfgetIndividualName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfgetIndividualName.ShouldNotBeNull();
            parametersOfgetIndividualName.Length.ShouldBe(4);
            methodgetIndividualNameParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var format = this.CreateType<IndividualNamingFormat>();
            var firstName = this.CreateType<string>();
            var middleName = this.CreateType<string>();
            var lastName = this.CreateType<string>();
            var methodgetIndividualNameParametersTypes = new Type[] { typeof(IndividualNamingFormat), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfgetIndividualName = { format, firstName, middleName, lastName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodgetIndividualName, parametersOfgetIndividualName, methodgetIndividualNameParametersTypes);

            // Assert
            parametersOfgetIndividualName.ShouldNotBeNull();
            parametersOfgetIndividualName.Length.ShouldBe(4);
            methodgetIndividualNameParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var methodgetIndividualNameParametersTypes = new Type[] { typeof(IndividualNamingFormat), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetIndividualName, methodgetIndividualNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodgetIndividualNameParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var methodgetIndividualNameParametersTypes = new Type[] { typeof(IndividualNamingFormat), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetIndividualName, methodgetIndividualNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetIndividualNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var currentMethodInfo = this.GetMethodInfo(MethodgetIndividualName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (getIndividualName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_getIndividualName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetIndividualName);
            var currentMethodInfo = this.GetMethodInfo(MethodgetIndividualName, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (addNode) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_addNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodaddNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodaddNode, methodaddNodeParametersTypes);
        }

        #endregion

        #region Method Call : (addNode) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_addNode_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNode);
            var document = this.CreateType<XmlDocument>();
            var path = this.CreateType<string>();
            var nodeName = this.CreateType<string>();
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.addNode(document, path, nodeName, value);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (addNode) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_addNode_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNode);
            var document = this.CreateType<XmlDocument>();
            var path = this.CreateType<string>();
            var nodeName = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodaddNodeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfaddNode = { document, path, nodeName, value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodaddNode, methodaddNodeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfaddNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfaddNode.ShouldNotBeNull();
            parametersOfaddNode.Length.ShouldBe(4);
            methodaddNodeParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (addNode) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_addNode_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNode);
            var document = this.CreateType<XmlDocument>();
            var path = this.CreateType<string>();
            var nodeName = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodaddNodeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfaddNode = { document, path, nodeName, value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodaddNode, parametersOfaddNode, methodaddNodeParametersTypes);

            // Assert
            parametersOfaddNode.ShouldNotBeNull();
            parametersOfaddNode.Length.ShouldBe(4);
            methodaddNodeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (addNode) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_addNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodaddNode);
            var currentMethodInfo = this.GetMethodInfo(MethodaddNode, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (IgnoreXmlComments) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_IgnoreXmlComments_Static_Method_Call_Internally(Type[] types)
        {
            var methodIgnoreXmlCommentsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIgnoreXmlComments, methodIgnoreXmlCommentsParametersTypes);
        }

        #endregion
        
        #region Method Call : (IgnoreXmlComments) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IgnoreXmlComments_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIgnoreXmlComments);
            var XmlPath = this.CreateType<string>();
            var methodIgnoreXmlCommentsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIgnoreXmlComments = { XmlPath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodIgnoreXmlComments, parametersOfIgnoreXmlComments, methodIgnoreXmlCommentsParametersTypes);

            // Assert
            parametersOfIgnoreXmlComments.ShouldNotBeNull();
            parametersOfIgnoreXmlComments.Length.ShouldBe(1);
            methodIgnoreXmlCommentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IgnoreXmlComments) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IgnoreXmlComments_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIgnoreXmlComments);
            var methodIgnoreXmlCommentsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIgnoreXmlComments, methodIgnoreXmlCommentsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIgnoreXmlCommentsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (IgnoreXmlComments) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IgnoreXmlComments_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIgnoreXmlComments);
            var currentMethodInfo = this.GetMethodInfo(MethodIgnoreXmlComments, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_BatchUpdateMapping_Static_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateMappingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdateMapping, methodBatchUpdateMappingParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var sourceXML = this.CreateType<string>();
            var lboName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.BatchUpdateMapping(sourceXML, lboName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var sourceXML = this.CreateType<string>();
            var lboName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.BatchUpdateMapping(sourceXML, lboName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var sourceXML = this.CreateType<string>();
            var lboName = this.CreateType<string>();
            var methodBatchUpdateMappingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfBatchUpdateMapping = { sourceXML, lboName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateMapping, methodBatchUpdateMappingParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodBatchUpdateMapping, methodBatchUpdateMappingParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodBatchUpdateMapping, parametersOfBatchUpdateMapping, methodBatchUpdateMappingParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfBatchUpdateMapping);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdateMapping.ShouldNotBeNull();
            parametersOfBatchUpdateMapping.Length.ShouldBe(2);
            methodBatchUpdateMappingParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var sourceXML = this.CreateType<string>();
            var lboName = this.CreateType<string>();
            var methodBatchUpdateMappingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfBatchUpdateMapping = { sourceXML, lboName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBatchUpdateMapping, parametersOfBatchUpdateMapping, methodBatchUpdateMappingParametersTypes);

            // Assert
            parametersOfBatchUpdateMapping.ShouldNotBeNull();
            parametersOfBatchUpdateMapping.Length.ShouldBe(2);
            methodBatchUpdateMappingParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var methodBatchUpdateMappingParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdateMapping, methodBatchUpdateMappingParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateMappingParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var methodBatchUpdateMappingParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdateMapping, methodBatchUpdateMappingParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateMappingParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateMapping, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateMapping) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_BatchUpdateMapping_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateMapping);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateMapping, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetContextData_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetContextDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextData, methodGetContextDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => Common.GetContextData(parameterCollection);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(ContextData);

            // Act
            Action executeAction = () => returnedValue = Common.GetContextData(parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetContextDataParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfGetContextData = { parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextData, methodGetContextDataParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetContextData, methodGetContextDataParametersTypes);
            var result2 = this.GetResultOfMethod<ContextData>(MethodGetContextData, parametersOfGetContextData, methodGetContextDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetContextData.ShouldNotBeNull();
            parametersOfGetContextData.Length.ShouldBe(1);
            methodGetContextDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<ContextData>(MethodGetContextData, parametersOfGetContextData, methodGetContextDataParametersTypes));
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetContextDataParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfGetContextData = { parameterCollection };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextData, methodGetContextDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetContextData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetContextData.ShouldNotBeNull();
            parametersOfGetContextData.Length.ShouldBe(1);
            methodGetContextDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetContextDataParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfGetContextData = { parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ContextData>(MethodGetContextData, parametersOfGetContextData, methodGetContextDataParametersTypes);

            // Assert
            parametersOfGetContextData.ShouldNotBeNull();
            parametersOfGetContextData.Length.ShouldBe(1);
            methodGetContextDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var methodGetContextDataParametersTypes = new Type[] { typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextData, methodGetContextDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetContextDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var methodGetContextDataParametersTypes = new Type[] { typeof(Hashtable) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextData, methodGetContextDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetContextData) (Return Type : ContextData) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetContextData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetLocalXMLString_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetLocalXMLStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLocalXMLString, methodGetLocalXMLStringParametersTypes);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var filePath = this.CreateType<string>();
            var langCode = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetLocalXMLString(filePath, langCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var filePath = this.CreateType<string>();
            var langCode = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetLocalXMLString(filePath, langCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var filePath = this.CreateType<string>();
            var langCode = this.CreateType<string>();
            var methodGetLocalXMLStringParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetLocalXMLString = { filePath, langCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLocalXMLString, methodGetLocalXMLStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetLocalXMLString, methodGetLocalXMLStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetLocalXMLString, parametersOfGetLocalXMLString, methodGetLocalXMLStringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetLocalXMLString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLocalXMLString.ShouldNotBeNull();
            parametersOfGetLocalXMLString.Length.ShouldBe(2);
            methodGetLocalXMLStringParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var filePath = this.CreateType<string>();
            var langCode = this.CreateType<string>();
            var methodGetLocalXMLStringParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetLocalXMLString = { filePath, langCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetLocalXMLString, parametersOfGetLocalXMLString, methodGetLocalXMLStringParametersTypes);

            // Assert
            parametersOfGetLocalXMLString.ShouldNotBeNull();
            parametersOfGetLocalXMLString.Length.ShouldBe(2);
            methodGetLocalXMLStringParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var methodGetLocalXMLStringParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLocalXMLString, methodGetLocalXMLStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLocalXMLStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var methodGetLocalXMLStringParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLocalXMLString, methodGetLocalXMLStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLocalXMLStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLocalXMLString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLocalXMLString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetLocalXMLString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLocalXMLString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLocalXMLString, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetMobileProfileName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMobileProfileNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMobileProfileName, methodGetMobileProfileNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var resultXDocument = this.CreateType<XDocument>();
            var LboObjectName = this.CreateType<string>();
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetMobileProfileName(resultXDocument, LboObjectName, EntityName, LanguageCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var resultXDocument = this.CreateType<XDocument>();
            var LboObjectName = this.CreateType<string>();
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetMobileProfileName(resultXDocument, LboObjectName, EntityName, LanguageCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var resultXDocument = this.CreateType<XDocument>();
            var LboObjectName = this.CreateType<string>();
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var methodGetMobileProfileNameParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetMobileProfileName = { resultXDocument, LboObjectName, EntityName, LanguageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMobileProfileName, methodGetMobileProfileNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMobileProfileName, methodGetMobileProfileNameParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetMobileProfileName, parametersOfGetMobileProfileName, methodGetMobileProfileNameParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetMobileProfileName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMobileProfileName.ShouldNotBeNull();
            parametersOfGetMobileProfileName.Length.ShouldBe(4);
            methodGetMobileProfileNameParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var resultXDocument = this.CreateType<XDocument>();
            var LboObjectName = this.CreateType<string>();
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var methodGetMobileProfileNameParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetMobileProfileName = { resultXDocument, LboObjectName, EntityName, LanguageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMobileProfileName, parametersOfGetMobileProfileName, methodGetMobileProfileNameParametersTypes);

            // Assert
            parametersOfGetMobileProfileName.ShouldNotBeNull();
            parametersOfGetMobileProfileName.Length.ShouldBe(4);
            methodGetMobileProfileNameParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var methodGetMobileProfileNameParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMobileProfileName, methodGetMobileProfileNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMobileProfileNameParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var methodGetMobileProfileNameParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMobileProfileName, methodGetMobileProfileNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMobileProfileNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMobileProfileName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMobileProfileName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMobileProfileName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMobileProfileName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMobileProfileName, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOwnerTypeForMobile) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetOwnerTypeForMobile_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOwnerTypeForMobileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOwnerTypeForMobile, methodGetOwnerTypeForMobileParametersTypes);
        }

        #endregion

        #region Method Call : (GetOwnerTypeForMobile) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOwnerTypeForMobile_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeForMobile);
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetOwnerTypeForMobile(EntityName, LanguageCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOwnerTypeForMobile) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOwnerTypeForMobile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeForMobile);
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var methodGetOwnerTypeForMobileParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetOwnerTypeForMobile = { EntityName, LanguageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetOwnerTypeForMobile, parametersOfGetOwnerTypeForMobile, methodGetOwnerTypeForMobileParametersTypes);

            // Assert
            parametersOfGetOwnerTypeForMobile.ShouldNotBeNull();
            parametersOfGetOwnerTypeForMobile.Length.ShouldBe(2);
            methodGetOwnerTypeForMobileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOwnerTypeForMobile) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOwnerTypeForMobile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeForMobile);
            var methodGetOwnerTypeForMobileParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOwnerTypeForMobile, methodGetOwnerTypeForMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOwnerTypeForMobileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOwnerTypeForMobile) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOwnerTypeForMobile_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOwnerTypeForMobile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOwnerTypeForMobile) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOwnerTypeForMobile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOwnerTypeForMobile, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetEntityNameForMobile_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityNameForMobileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetEntityNameForMobile(EntityName, LanguageCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetEntityNameForMobile(EntityName, LanguageCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var methodGetEntityNameForMobileParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetEntityNameForMobile = { EntityName, LanguageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetEntityNameForMobile, parametersOfGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEntityNameForMobile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityNameForMobile.ShouldNotBeNull();
            parametersOfGetEntityNameForMobile.Length.ShouldBe(2);
            methodGetEntityNameForMobileParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var EntityName = this.CreateType<string>();
            var LanguageCode = this.CreateType<string>();
            var methodGetEntityNameForMobileParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetEntityNameForMobile = { EntityName, LanguageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEntityNameForMobile, parametersOfGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes);

            // Assert
            parametersOfGetEntityNameForMobile.ShouldNotBeNull();
            parametersOfGetEntityNameForMobile.Length.ShouldBe(2);
            methodGetEntityNameForMobileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var methodGetEntityNameForMobileParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityNameForMobileParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var methodGetEntityNameForMobileParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityNameForMobile, methodGetEntityNameForMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityNameForMobileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityNameForMobile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityNameForMobile) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEntityNameForMobile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityNameForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityNameForMobile, 0);
            const int parametersCount = 2;

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