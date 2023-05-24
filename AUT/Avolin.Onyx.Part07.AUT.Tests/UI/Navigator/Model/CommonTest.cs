using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.Common" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
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
        private Common _commonInstance;
        private Common _commonInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            _commonInstanceFixture = this.Create<Common>(false);
            _commonInstance = _commonInstanceFixture ?? this.Create<Common>(true);
            CurrentInstance = _commonInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodToTitleCase = "ToTitleCase";
        private const string MethodGetUnMaskedText = "GetUnMaskedText";
        private const string MethodGetMaskedText = "GetMaskedText";
        private const string MethodGetMaskFormat = "GetMaskFormat";
        private const string MethodCheckUIPermission = "CheckUIPermission";
        private const string MethodIsQueryExists = "IsQueryExists";
        private const string MethodIsValidQuery = "IsValidQuery";
        private const string MethodSafeXml = "SafeXml";

        #endregion

        #region Fields

        private const string FieldmaskEditControl = "maskEditControl";
        private const string FieldSEARCH_MALE_DISPLAY_VALUE = "SEARCH_MALE_DISPLAY_VALUE";
        private const string FieldSEARCH_FEMALE_DISPLAY_VALUE = "SEARCH_FEMALE_DISPLAY_VALUE";
        private const string FieldEMAIL_DRAFT_YES_DISPLAY_VALUE = "EMAIL_DRAFT_YES_DISPLAY_VALUE";
        private const string FieldEMAIL_DRAFT_NO_DISPLAY_VALUE = "EMAIL_DRAFT_NO_DISPLAY_VALUE";
        private const string FieldEMAIL_FOLLOW_UP_YES_DISPLAY_VALUE = "EMAIL_FOLLOW_UP_YES_DISPLAY_VALUE";
        private const string FieldEMAIL_FOLLOW_UP_NO_DISPLAY_VALUE = "EMAIL_FOLLOW_UP_NO_DISPLAY_VALUE";
        private const string FieldDEFAULT_OPERATOR_TEXT = "DEFAULT_OPERATOR_TEXT";
        private const string FieldOPERATOR_EQUAL_TO = "OPERATOR_EQUAL_TO";
        private const string FieldOPERATOR_NOT_EQUAL_TO = "OPERATOR_NOT_EQUAL_TO";
        private const string FieldOPERATOR_GREATOR_THAN = "OPERATOR_GREATOR_THAN";
        private const string FieldOPERATOR_LESS_THAN = "OPERATOR_LESS_THAN";
        private const string FieldOPERATOR_GREATOR_THAN_EQUAL_TO = "OPERATOR_GREATOR_THAN_EQUAL_TO";
        private const string FieldOPERATOR_LESS_THAN_EQUAL_TO = "OPERATOR_LESS_THAN_EQUAL_TO";
        private const string FieldOPERATOR_BETWEEN = "OPERATOR_BETWEEN";
        private const string FieldOPERATOR_IS_NULL = "OPERATOR_IS_NULL";
        private const string FieldOPERATOR_IS_NOT_NULL = "OPERATOR_IS_NOT_NULL";
        private const string FieldOPERATOR_LIKE = "OPERATOR_LIKE";
        private const string FieldOPERATOR_NOT_EQUAL_TO_CODE = "OPERATOR_NOT_EQUAL_TO_CODE";
        private const string FieldOPERATOR_EQUAL_TO_CODE = "OPERATOR_EQUAL_TO_CODE";
        private const string FieldOPERATOR_GREATOR_THAN_CODE = "OPERATOR_GREATOR_THAN_CODE";
        private const string FieldOPERATOR_LESS_THAN_CODE = "OPERATOR_LESS_THAN_CODE";
        private const string FieldOPERATOR_GREATOR_THAN_EQUAL_TO_CODE = "OPERATOR_GREATOR_THAN_EQUAL_TO_CODE";
        private const string FieldOPERATOR_LESS_THAN_EQUAL_TO_CODE = "OPERATOR_LESS_THAN_EQUAL_TO_CODE";
        private const string FieldOPERATOR_BETWEEN_CODE = "OPERATOR_BETWEEN_CODE";
        private const string FieldOPERATOR_CONTAINS = "OPERATOR_CONTAINS";
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
        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldNAVIGATOR_BLANK_ENTRY = "NAVIGATOR_BLANK_ENTRY";
        private const string FieldNAVIGATOR_BROWSE_ENTITY_SOURCE = "NAVIGATOR_BROWSE_ENTITY_SOURCE";
        private const string FieldBROWSE_COMPANY_PANEL_SOURCE = "BROWSE_COMPANY_PANEL_SOURCE";
        private const string FieldBROWSE_FORECAST_PANEL_SOURCE = "BROWSE_FORECAST_PANEL_SOURCE";
        private const string FieldBROWSE_INDIVIDUAL_PANEL_SOURCE = "BROWSE_INDIVIDUAL_PANEL_SOURCE";
        private const string FieldBROWSE_SALES_PANEL_SOURCE = "BROWSE_SALES_PANEL_SOURCE";
        private const string FieldBROWSE_SERVICE_PANEL_SOURCE = "BROWSE_SERVICE_PANEL_SOURCE";
        private const string FieldBROWSE_SUPPORT_PANEL_SOURCE = "BROWSE_SUPPORT_PANEL_SOURCE";
        private const string FieldBROWSE_TASK_PANEL_SOURCE = "BROWSE_TASK_PANEL_SOURCE";
        private const string FieldBROWSE_WORKTICKET_PANEL_SOURCE = "BROWSE_WORKTICKET_PANEL_SOURCE";
        private const string FieldBROWSE_DATE_ENUMERATOR_SOURCE = "BROWSE_DATE_ENUMERATOR_SOURCE";
        private const string FieldNAVIGATOR_SEARCH_ENTITY_SOURCE = "NAVIGATOR_SEARCH_ENTITY_SOURCE";
        private const string FieldSEARCH_COMPANY_FILTER_SOURCE = "SEARCH_COMPANY_FILTER_SOURCE";
        private const string FieldSEARCH_INDIVIDUAL_FILTER_SOURCE = "SEARCH_INDIVIDUAL_FILTER_SOURCE";
        private const string FieldSEARCH_SALES_FILTER_SOURCE = "SEARCH_SALES_FILTER_SOURCE";
        private const string FieldSEARCH_SERVICE_FILTER_SOURCE = "SEARCH_SERVICE_FILTER_SOURCE";
        private const string FieldSEARCH_SUPPORT_FILTER_SOURCE = "SEARCH_SUPPORT_FILTER_SOURCE";
        private const string FieldSEARCH_TASK_FILTER_SOURCE = "SEARCH_TASK_FILTER_SOURCE";
        private const string FieldSEARCH_WORKTICKET_FILTER_SOURCE = "SEARCH_WORKTICKET_FILTER_SOURCE";
        private const string FieldSEARCH_FORECAST_FILTER_SOURCE = "SEARCH_FORECAST_FILTER_SOURCE";
        private const string FieldSEARCH_SCRIPT_FILTER_SOURCE = "SEARCH_SCRIPT_FILTER_SOURCE";
        private const string FieldSEARCH_APPOINTMENT_FILTER_SOURCE = "SEARCH_APPOINTMENT_FILTER_SOURCE";
        private const string FieldSEARCH_EMAIL_FILTER_SOURCE = "SEARCH_EMAIL_FILTER_SOURCE";
        private const string FieldSEARCH_CUSTOMER_FILTER_SOURCE = "SEARCH_CUSTOMER_FILTER_SOURCE";
        private const string FieldSEARCH_PRODUCT_FILTER_SOURCE = "SEARCH_PRODUCT_FILTER_SOURCE";
        private const string FieldDOCK_SOURCE = "DOCK_SOURCE";
        private const string FieldALL_UI_RESOURCES = "ALL_UI_RESOURCES";
        private const string FieldMODULE_PRIVILEGE_SOURCE = "MODULE_PRIVILEGE_SOURCE";
        private const string FieldDISPLAY_PROFILE_SOURCE = "DISPLAY_PROFILE_SOURCE";
        private const string FieldBATCH_UPDATE_SOURCE = "BATCH_UPDATE_SOURCE";
        private const string FieldRESULT_GRID_MANAGER_SOURCE = "RESULT_GRID_MANAGER_SOURCE";
        private const string FieldRESULT_GRID_MANAGER_PROPERTY_MASTER = "RESULT_GRID_MANAGER_PROPERTY_MASTER";
        private const string FieldRESULT_GRID_RESTORE_DEFAULT = "RESULT_GRID_RESTORE_DEFAULT";
        private const string FieldSEARCH_FILTER_SOURCE = "SEARCH_FILTER_SOURCE";
        private const string FieldSEARCH_FILTER_MANAGER_PROPERTY_MASTER = "SEARCH_FILTER_MANAGER_PROPERTY_MASTER";
        private const string FieldSEARCH_FILTER_RESTORE_DEFAULT = "SEARCH_FILTER_RESTORE_DEFAULT";
        private const string FieldGAM_CONFIGURATION = "GAM_CONFIGURATION";
        private const string FieldDATA_TYPE_STRING = "DATA_TYPE_STRING";
        private const string FieldDATA_TYPE_INTEGER = "DATA_TYPE_INTEGER";
        private const string FieldPARAMETER_DELIMITER = "PARAMETER_DELIMITER";
        private const string FieldFORMAT_DATE_TIME = "FORMAT_DATE_TIME";
        private const string FieldFORMAT_DATE = "FORMAT_DATE";
        private const string FieldFORMAT_LOGICAL_EXPRESSION_BETWEEN = "FORMAT_LOGICAL_EXPRESSION_BETWEEN";
        private const string FieldFORMAT_LOGICAL_EXPRESSION_EQUAL = "FORMAT_LOGICAL_EXPRESSION_EQUAL";
        private const string FieldFORMAT_DATE_TIME24 = "FORMAT_DATE_TIME24";
        private const string FieldSQLFORMAT_DATE_TIME24 = "SQLFORMAT_DATE_TIME24";
        private const string FieldFORMAT_STARTDATE24 = "FORMAT_STARTDATE24";
        private const string FieldFORMAT_ENDDATE24 = "FORMAT_ENDDATE24";
        private const string FieldFORMAT_RECALLDATE = "FORMAT_RECALLDATE";
        private const string FieldFORMAT_RECALLTIME = "FORMAT_RECALLTIME";
        private const string FieldQUERY_ADMINISTRATION_XAP = "QUERY_ADMINISTRATION_XAP";
        private const string FieldQUERY_ADMINISTRATION_ASSEMBLY = "QUERY_ADMINISTRATION_ASSEMBLY";
        private const string FieldNAVIGATOR_SEARCH_ASSEMBLY = "NAVIGATOR_SEARCH_ASSEMBLY";
        private const string FieldNAVIGATOR_SEARCH_CLASS = "NAVIGATOR_SEARCH_CLASS";
        private const string FieldRESULT_GRID_MANAGER_ASSEMBLY = "RESULT_GRID_MANAGER_ASSEMBLY";
        private const string FieldSEARCH_FILTER_MANAGER_ASSEMBLY = "SEARCH_FILTER_MANAGER_ASSEMBLY";
        private const string FieldSEARCH_FILTER_MANAGER_XAP = "SEARCH_FILTER_MANAGER_XAP";
        private const string FieldRESULT_GRID_MANAGER_XAP = "RESULT_GRID_MANAGER_XAP";
        private const string FieldQUERY_ADMINISTRATION_INSTANCE = "QUERY_ADMINISTRATION_INSTANCE";
        private const string FieldSEARCH_FILTER_MANAGER_INSTANCE = "SEARCH_FILTER_MANAGER_INSTANCE";
        private const string FieldRESULT_GRID_MANAGER_INSTANCE = "RESULT_GRID_MANAGER_INSTANCE";
        private const string FieldSEARCH_FILTER_ADMINISTRATION = "SEARCH_FILTER_ADMINISTRATION";
        private const string FieldRESULT_GRID_ADMINISTRATION = "RESULT_GRID_ADMINISTRATION";
        private const string FieldQUERY_EXPLORER_ADMINISTRATION = "QUERY_EXPLORER_ADMINISTRATION";
        private const string FieldRESULT_GRID_DEFAULT_MAX_ROWS = "RESULT_GRID_DEFAULT_MAX_ROWS";
        private const string FieldRESULT_GRID_DEFAULT_MIN_ROWS = "RESULT_GRID_DEFAULT_MIN_ROWS";
        
        private const string FieldRESULT_GRID_DEFAULT_MIN_PAGESIZE = "RESULT_GRID_DEFAULT_MIN_PAGESIZE";
        private const string FieldPUBLIC_QUERY_FOLDER_ID = "PUBLIC_QUERY_FOLDER_ID";
        private const string FieldPERSONAL_QUERY_FOLDER_ID = "PERSONAL_QUERY_FOLDER_ID";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_MODULE = "SEARCH_CRITERIA_ADMINISTRATION_MODULE";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_AVAILABLE_LIST = "SEARCH_CRITERIA_ADMINISTRATION_AVAILABLE_LIST";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_DEFAULT_LIST = "SEARCH_CRITERIA_ADMINISTRATION_DEFAULT_LIST";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_DISABLED_LIST = "SEARCH_CRITERIA_ADMINISTRATION_DISABLED_LIST";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_PROPERTY_EDIT = "SEARCH_CRITERIA_ADMINISTRATION_PROPERTY_EDIT";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_RESETDEFAULT_VIEW = "SEARCH_CRITERIA_ADMINISTRATION_RESETDEFAULT_VIEW";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_PROPERTY_EDIT_ISREQUIRED = "SEARCH_CRITERIA_ADMINISTRATION_PROPERTY_EDIT_ISREQUIRED";
        private const string FieldRESULT_GRID_ADMINISTRATION_MODULE = "RESULT_GRID_ADMINISTRATION_MODULE";
        private const string FieldRESULT_GRID_ADMINISTRATION_AVAILABLE_LIST = "RESULT_GRID_ADMINISTRATION_AVAILABLE_LIST";
        private const string FieldRESULT_GRID_ADMINISTRATION_DISABLED_LIST = "RESULT_GRID_ADMINISTRATION_DISABLED_LIST";
        private const string FieldRESULT_GRID_ADMINISTRATION_HEADER_LIST = "RESULT_GRID_ADMINISTRATION_HEADER_LIST";
        private const string FieldRESULT_GRID_ADMINISTRATION_PROPERTY_EDIT = "RESULT_GRID_ADMINISTRATION_PROPERTY_EDIT";
        private const string FieldRESULT_GRID_ADMINISTRATION_MAX_RECORDS = "RESULT_GRID_ADMINISTRATION_MAX_RECORDS";
        private const string FieldRESULT_GRID_ADMINISTRATION_PAGE_SIZE = "RESULT_GRID_ADMINISTRATION_PAGE_SIZE";
        private const string FieldRESULT_GRID_ADMINISTRATION_RESETDEFAULT_VIEW = "RESULT_GRID_ADMINISTRATION_RESETDEFAULT_VIEW";
        private const string FieldHOME_PAGE_MODULE = "HOME_PAGE_MODULE";
        private const string FieldTOP_TAB_HEIGHT = "TOP_TAB_HEIGHT";
        private const string FieldBUTTON_SELECT_FIELDS_QUERY = "BUTTON_SELECT_FIELDS_QUERY";
        private const string FieldBUTTON_ACCESS_BOOKMARK = "BUTTON_ACCESS_BOOKMARK";
        private const string FieldBUTTON_CONFIGURE_RESULTGRID = "BUTTON_CONFIGURE_RESULTGRID";
        private const string FieldBUTTON_PRINT_RESULTS = "BUTTON_PRINT_RESULTS";
        private const string FieldBUTTON_EXPORT_CSV = "BUTTON_EXPORT_CSV";
        private const string FieldBUTTON_MERGE_COMPANY = "BUTTON_MERGE_COMPANY";
        private const string FieldBUTTON_MERGE_INDIVIDUAL = "BUTTON_MERGE_INDIVIDUAL";
        private const string FieldBUTTON_CREATE_PRIVATE_FOLDER = "BUTTON_CREATE_PRIVATE_FOLDER";
        private const string FieldBUTTON_DELETE_PRIVATE_FOLDER = "BUTTON_DELETE_PRIVATE_FOLDER";
        private const string FieldBUTTON_CREATE_PUBLIC_FOLDER = "BUTTON_CREATE_PUBLIC_FOLDER";
        private const string FieldBUTTON_DELETE_PUBLIC_FOLDER = "BUTTON_DELETE_PUBLIC_FOLDER";
        private const string FieldBUTTON_CREATE_PUBLIC_QUERY = "BUTTON_CREATE_PUBLIC_QUERY";
        private const string FieldBUTTON_DELETE_PUBLIC_QUERY = "BUTTON_DELETE_PUBLIC_QUERY";
        private const string FieldQUERY_EXPLORER_SHOW_BOOKMARK = "QUERY_EXPLORER_SHOW_BOOKMARK";
        private const string FieldQUERY_EXPLORER_SHOW_HOMEPAGEBOOKMARK = "QUERY_EXPLORER_SHOW_HOMEPAGEBOOKMARK";
        private const string FieldQUERY_EXPLORER_SHOW_MOBILEBOOKMARK = "QUERY_EXPLORER_SHOW_MOBILEBOOKMARK";
        private const string FieldFILTERNAME_COMPANY_COUNTRY = "FILTERNAME_COMPANY_COUNTRY";
        private const string FieldFILTERNAME_COMPANY_TYPE = "FILTERNAME_COMPANY_TYPE";
        private const string FieldFILTERNAME_COMPANY_SUBTYPE = "FILTERNAME_COMPANY_SUBTYPE";
        private const string FieldFILTERNAME_COMPANY_SICCODE = "FILTERNAME_COMPANY_SICCODE";
        private const string FieldFILTERNAME_COMPANY_MARKETSECTOR = "FILTERNAME_COMPANY_MARKETSECTOR";
        private const string FieldFILTERNAME_COMPANY_SOURCE = "FILTERNAME_COMPANY_SOURCE";
        private const string FieldFILTERNAME_COMPANY_STATUS = "FILTERNAME_COMPANY_STATUS";
        private const string FieldFILTERNAME_COMPANY_STATE = "FILTERNAME_COMPANY_STATE";
        private const string FieldFILTERNAME_INDIVIDUAL_COUNTRY = "FILTERNAME_INDIVIDUAL_COUNTRY";
        private const string FieldFILTERNAME_INDIVIDUAL_GENDER = "FILTERNAME_INDIVIDUAL_GENDER";
        private const string FieldFILTERNAME_INDIVIDUAL_TITLE = "FILTERNAME_INDIVIDUAL_TITLE";
        private const string FieldFILTERNAME_INDIVIDUAL_DEPARTMENT = "FILTERNAME_INDIVIDUAL_DEPARTMENT";
        private const string FieldFILTERNAME_INDIVIDUAL_SOURCE = "FILTERNAME_INDIVIDUAL_SOURCE";
        private const string FieldFILTERNAME_INDIVIDUAL_STATUS = "FILTERNAME_INDIVIDUAL_STATUS";
        private const string FieldFILTERNAME_INDIVIDUAL_STATE = "FILTERNAME_INDIVIDUAL_STATE";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_TYPE = "FILTERNAME_SALESOPPORTUNITY_TYPE";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_PRODUCT = "FILTERNAME_SALESOPPORTUNITY_PRODUCT";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_STATUS = "FILTERNAME_SALESOPPORTUNITY_STATUS";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_PRIORITY = "FILTERNAME_SALESOPPORTUNITY_PRIORITY";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_SOURCE = "FILTERNAME_SALESOPPORTUNITY_SOURCE";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE1 = "FILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE1";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE2 = "FILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE2";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE3 = "FILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE3";
        private const string FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE4 = "FILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE4";
        private const string FieldFILTERNAME_SERVICEREQUEST_TYPE = "FILTERNAME_SERVICEREQUEST_TYPE";
        private const string FieldFILTERNAME_SERVICEREQUEST_PRODUCT = "FILTERNAME_SERVICEREQUEST_PRODUCT";
        private const string FieldFILTERNAME_SERVICEREQUEST_STATUS = "FILTERNAME_SERVICEREQUEST_STATUS";
        private const string FieldFILTERNAME_SERVICEREQUEST_PRIORITY = "FILTERNAME_SERVICEREQUEST_PRIORITY";
        private const string FieldFILTERNAME_SERVICEREQUEST_SOURCE = "FILTERNAME_SERVICEREQUEST_SOURCE";
        private const string FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE1 = "FILTERNAME_SERVICEREQUEST_RESOLUTIONCODE1";
        private const string FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE2 = "FILTERNAME_SERVICEREQUEST_RESOLUTIONCODE2";
        private const string FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE3 = "FILTERNAME_SERVICEREQUEST_RESOLUTIONCODE3";
        private const string FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE4 = "FILTERNAME_SERVICEREQUEST_RESOLUTIONCODE4";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_TYPE = "FILTERNAME_SUPPORTINCIDENT_TYPE";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_PRODUCT = "FILTERNAME_SUPPORTINCIDENT_PRODUCT";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_STATUS = "FILTERNAME_SUPPORTINCIDENT_STATUS";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_PRIORITY = "FILTERNAME_SUPPORTINCIDENT_PRIORITY";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_SOURCE = "FILTERNAME_SUPPORTINCIDENT_SOURCE";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE1 = "FILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE1";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE2 = "FILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE2";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE3 = "FILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE3";
        private const string FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE4 = "FILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE4";
        private const string FieldFILTERNAME_WORKTICKET_TYPE = "FILTERNAME_WORKTICKET_TYPE";
        private const string FieldFILTERNAME_WORKTICKET_PRODUCT = "FILTERNAME_WORKTICKET_PRODUCT";
        private const string FieldFILTERNAME_WORKTICKET_STATUS = "FILTERNAME_WORKTICKET_STATUS";
        private const string FieldFILTERNAME_WORKTICKET_PRIORITY = "FILTERNAME_WORKTICKET_PRIORITY";
        private const string FieldFILTERNAME_WORKTICKET_SOURCE = "FILTERNAME_WORKTICKET_SOURCE";
        private const string FieldFILTERNAME_WORKTICKET_SEVERITY = "FILTERNAME_WORKTICKET_SEVERITY";
        private const string FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE1 = "FILTERNAME_WORKTICKET_RESOLUTIONCODE1";
        private const string FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE2 = "FILTERNAME_WORKTICKET_RESOLUTIONCODE2";
        private const string FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE3 = "FILTERNAME_WORKTICKET_RESOLUTIONCODE3";
        private const string FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE4 = "FILTERNAME_WORKTICKET_RESOLUTIONCODE4";
        private const string FieldFILTERNAME_EMAIL_SENT = "FILTERNAME_EMAIL_SENT";
        private const string FieldFILTERNAME_EMAIL_PRIORITY = "FILTERNAME_EMAIL_PRIORITY";
        private const string FieldFILTERNAME_EMAIL_FOLLOWUP = "FILTERNAME_EMAIL_FOLLOWUP";
        private const string FieldFILTERNAME_EMAIL_DRAFT = "FILTERNAME_EMAIL_DRAFT";
        private const string FieldFILTERNAME_TASK_TYPE = "FILTERNAME_TASK_TYPE";
        private const string FieldFILTERNAME_TASK_STATUS = "FILTERNAME_TASK_STATUS";
        private const string FieldFILTERNAME_TASK_PRIORITY = "FILTERNAME_TASK_PRIORITY";
        private const string FieldFILTERNAME_TASK_CATEGORY = "FILTERNAME_TASK_CATEGORY";
        private const string FieldFILTERNAME_SCRIPT_STATUS = "FILTERNAME_SCRIPT_STATUS";
        private const string FieldFILTERNAME_FORECAST_STATUS = "FILTERNAME_FORECAST_STATUS";
        private const string FieldFILTERNAME_PRODUCT_STATUS = "FILTERNAME_PRODUCT_STATUS";
        private const string FieldFILTERNAME_FORECAST_CLOSEPROBABILITY = "FILTERNAME_FORECAST_CLOSEPROBABILITY";
        private const string FieldFILTERNAME_STATUSDESC = "FILTERNAME_STATUSDESC";
        private const string FieldFILTERNAME_PRIORITYDESC = "FILTERNAME_PRIORITYDESC";
        private const string FieldFILTERNAME_SOURCEDESC = "FILTERNAME_SOURCEDESC";
        private const string FieldFILTERNAME_TYPEDESC = "FILTERNAME_TYPEDESC";
        private const string FieldFILTERNAME_PRODUCTDESC = "FILTERNAME_PRODUCTDESC";
        private const string FieldFILTERNAME_SEVERITY = "FILTERNAME_SEVERITY";
        private const string FieldFILTERNAME_VERSIONFOUND = "FILTERNAME_VERSIONFOUND";
        private const string FieldFILTERNAME_VERSIONFIXED = "FILTERNAME_VERSIONFIXED";
        private const string FieldFILTERNAME_VERSIONSHIPPED = "FILTERNAME_VERSIONSHIPPED";
        private const string FieldDEFAULT_BIT_TEXT = "DEFAULT_BIT_TEXT";
        private const string FieldDEFAULT_DATETIME_FORMAT = "DEFAULT_DATETIME_FORMAT";
        private const string FieldCACHE_TIMESTAMP = "CACHE_TIMESTAMP";
        private const string FieldSPACER = "SPACER";
        private const string FieldSPACER2 = "SPACER2";
        private const string FieldHEADER_HEIGHT = "HEADER_HEIGHT";
        private const string FieldSEARCH_CRITERIA_WIDTH = "SEARCH_CRITERIA_WIDTH";
        private const string FieldLEFT_RIGHT_MARGIN = "LEFT_RIGHT_MARGIN";
        private const string FieldTOP_DOWN_MARGIN = "TOP_DOWN_MARGIN";
        private const string FieldIsPublicQueryLoaded = "IsPublicQueryLoaded";
        private const string FieldCALL_FROM = "CALL_FROM";
        private const string FieldTOP_DIALOG_MARGIN = "TOP_DIALOG_MARGIN";
        private const string FieldLEFT_DIALOG_MARGIN = "LEFT_DIALOG_MARGIN";
        private const string FieldINDIVIDUAL_WATCH = "INDIVIDUAL_WATCH";
        private const string FieldCOMPANY_WATCH = "COMPANY_WATCH";
        private const string FieldSALES_WATCH = "SALES_WATCH";
        private const string FieldSERVICE_WATCH = "SERVICE_WATCH";
        private const string FieldSUPPORT_WATCH = "SUPPORT_WATCH";
        private const string FieldWATCH_ICON = "WATCH_ICON";
        private const string FieldUNWATCH_ICON = "UNWATCH_ICON";
        private const string FieldWATCH_DISABLE_ICON = "WATCH_DISABLE_ICON";
        private const string FieldLBO_COMPANY = "LBO_COMPANY";
        private const string FieldLBO_INDIVIDUAL = "LBO_INDIVIDUAL";
        private const string FieldLBO_INCIDENT = "LBO_INCIDENT";

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
        [TestCase(MethodToTitleCase, 0)]
        [TestCase(MethodGetUnMaskedText, 0)]
        [TestCase(MethodGetMaskedText, 0)]
        [TestCase(MethodGetMaskFormat, 0)]
        [TestCase(MethodCheckUIPermission, 0)]
        [TestCase(MethodIsQueryExists, 0)]
        [TestCase(MethodIsValidQuery, 0)]
        [TestCase(MethodSafeXml, 0)]
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
        [TestCase(FieldmaskEditControl)]
        [TestCase(FieldSEARCH_MALE_DISPLAY_VALUE)]
        [TestCase(FieldSEARCH_FEMALE_DISPLAY_VALUE)]
        [TestCase(FieldEMAIL_DRAFT_YES_DISPLAY_VALUE)]
        [TestCase(FieldEMAIL_DRAFT_NO_DISPLAY_VALUE)]
        [TestCase(FieldEMAIL_FOLLOW_UP_YES_DISPLAY_VALUE)]
        [TestCase(FieldEMAIL_FOLLOW_UP_NO_DISPLAY_VALUE)]
        [TestCase(FieldDEFAULT_OPERATOR_TEXT)]
        [TestCase(FieldOPERATOR_EQUAL_TO)]
        [TestCase(FieldOPERATOR_NOT_EQUAL_TO)]
        [TestCase(FieldOPERATOR_GREATOR_THAN)]
        [TestCase(FieldOPERATOR_LESS_THAN)]
        [TestCase(FieldOPERATOR_GREATOR_THAN_EQUAL_TO)]
        [TestCase(FieldOPERATOR_LESS_THAN_EQUAL_TO)]
        [TestCase(FieldOPERATOR_BETWEEN)]
        [TestCase(FieldOPERATOR_IS_NULL)]
        [TestCase(FieldOPERATOR_IS_NOT_NULL)]
        [TestCase(FieldOPERATOR_LIKE)]
        [TestCase(FieldOPERATOR_NOT_EQUAL_TO_CODE)]
        [TestCase(FieldOPERATOR_EQUAL_TO_CODE)]
        [TestCase(FieldOPERATOR_GREATOR_THAN_CODE)]
        [TestCase(FieldOPERATOR_LESS_THAN_CODE)]
        [TestCase(FieldOPERATOR_GREATOR_THAN_EQUAL_TO_CODE)]
        [TestCase(FieldOPERATOR_LESS_THAN_EQUAL_TO_CODE)]
        [TestCase(FieldOPERATOR_BETWEEN_CODE)]
        [TestCase(FieldOPERATOR_CONTAINS)]
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
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldNAVIGATOR_BLANK_ENTRY)]
        [TestCase(FieldNAVIGATOR_BROWSE_ENTITY_SOURCE)]
        [TestCase(FieldBROWSE_COMPANY_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_FORECAST_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_INDIVIDUAL_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_SALES_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_SERVICE_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_SUPPORT_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_TASK_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_WORKTICKET_PANEL_SOURCE)]
        [TestCase(FieldBROWSE_DATE_ENUMERATOR_SOURCE)]
        [TestCase(FieldNAVIGATOR_SEARCH_ENTITY_SOURCE)]
        [TestCase(FieldSEARCH_COMPANY_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_INDIVIDUAL_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_SALES_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_SERVICE_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_SUPPORT_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_TASK_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_WORKTICKET_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_FORECAST_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_SCRIPT_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_APPOINTMENT_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_EMAIL_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_CUSTOMER_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_PRODUCT_FILTER_SOURCE)]
        [TestCase(FieldDOCK_SOURCE)]
        [TestCase(FieldALL_UI_RESOURCES)]
        [TestCase(FieldMODULE_PRIVILEGE_SOURCE)]
        [TestCase(FieldDISPLAY_PROFILE_SOURCE)]
        [TestCase(FieldBATCH_UPDATE_SOURCE)]
        [TestCase(FieldRESULT_GRID_MANAGER_SOURCE)]
        [TestCase(FieldRESULT_GRID_MANAGER_PROPERTY_MASTER)]
        [TestCase(FieldRESULT_GRID_RESTORE_DEFAULT)]
        [TestCase(FieldSEARCH_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_FILTER_MANAGER_PROPERTY_MASTER)]
        [TestCase(FieldSEARCH_FILTER_RESTORE_DEFAULT)]
        [TestCase(FieldGAM_CONFIGURATION)]
        [TestCase(FieldDATA_TYPE_STRING)]
        [TestCase(FieldDATA_TYPE_INTEGER)]
        [TestCase(FieldPARAMETER_DELIMITER)]
        [TestCase(FieldFORMAT_DATE_TIME)]
        [TestCase(FieldFORMAT_DATE)]
        [TestCase(FieldFORMAT_LOGICAL_EXPRESSION_BETWEEN)]
        [TestCase(FieldFORMAT_LOGICAL_EXPRESSION_EQUAL)]
        [TestCase(FieldFORMAT_DATE_TIME24)]
        [TestCase(FieldSQLFORMAT_DATE_TIME24)]
        [TestCase(FieldFORMAT_STARTDATE24)]
        [TestCase(FieldFORMAT_ENDDATE24)]
        [TestCase(FieldFORMAT_RECALLDATE)]
        [TestCase(FieldFORMAT_RECALLTIME)]
        [TestCase(FieldQUERY_ADMINISTRATION_XAP)]
        [TestCase(FieldQUERY_ADMINISTRATION_ASSEMBLY)]
        [TestCase(FieldNAVIGATOR_SEARCH_ASSEMBLY)]
        [TestCase(FieldNAVIGATOR_SEARCH_CLASS)]
        [TestCase(FieldRESULT_GRID_MANAGER_ASSEMBLY)]
        [TestCase(FieldSEARCH_FILTER_MANAGER_ASSEMBLY)]
        [TestCase(FieldSEARCH_FILTER_MANAGER_XAP)]
        [TestCase(FieldRESULT_GRID_MANAGER_XAP)]
        [TestCase(FieldQUERY_ADMINISTRATION_INSTANCE)]
        [TestCase(FieldSEARCH_FILTER_MANAGER_INSTANCE)]
        [TestCase(FieldRESULT_GRID_MANAGER_INSTANCE)]
        [TestCase(FieldSEARCH_FILTER_ADMINISTRATION)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION)]
        [TestCase(FieldQUERY_EXPLORER_ADMINISTRATION)]
        [TestCase(FieldRESULT_GRID_DEFAULT_MAX_ROWS)]
        [TestCase(FieldRESULT_GRID_DEFAULT_MIN_ROWS)]
        [TestCase(FieldPUBLIC_QUERY_FOLDER_ID)]
        [TestCase(FieldPERSONAL_QUERY_FOLDER_ID)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_MODULE)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_AVAILABLE_LIST)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_DEFAULT_LIST)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_DISABLED_LIST)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_PROPERTY_EDIT)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_RESETDEFAULT_VIEW)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_PROPERTY_EDIT_ISREQUIRED)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_MODULE)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_AVAILABLE_LIST)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_DISABLED_LIST)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_HEADER_LIST)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_PROPERTY_EDIT)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_MAX_RECORDS)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_RESETDEFAULT_VIEW)]
        [TestCase(FieldHOME_PAGE_MODULE)]
        [TestCase(FieldTOP_TAB_HEIGHT)]
        [TestCase(FieldBUTTON_SELECT_FIELDS_QUERY)]
        [TestCase(FieldBUTTON_ACCESS_BOOKMARK)]
        [TestCase(FieldBUTTON_CONFIGURE_RESULTGRID)]
        [TestCase(FieldBUTTON_PRINT_RESULTS)]
        [TestCase(FieldBUTTON_EXPORT_CSV)]
        [TestCase(FieldBUTTON_MERGE_COMPANY)]
        [TestCase(FieldBUTTON_MERGE_INDIVIDUAL)]
        [TestCase(FieldBUTTON_CREATE_PRIVATE_FOLDER)]
        [TestCase(FieldBUTTON_DELETE_PRIVATE_FOLDER)]
        [TestCase(FieldBUTTON_CREATE_PUBLIC_FOLDER)]
        [TestCase(FieldBUTTON_DELETE_PUBLIC_FOLDER)]
        [TestCase(FieldBUTTON_CREATE_PUBLIC_QUERY)]
        [TestCase(FieldBUTTON_DELETE_PUBLIC_QUERY)]
        [TestCase(FieldQUERY_EXPLORER_SHOW_BOOKMARK)]
        [TestCase(FieldQUERY_EXPLORER_SHOW_HOMEPAGEBOOKMARK)]
        [TestCase(FieldQUERY_EXPLORER_SHOW_MOBILEBOOKMARK)]
        [TestCase(FieldFILTERNAME_COMPANY_COUNTRY)]
        [TestCase(FieldFILTERNAME_COMPANY_TYPE)]
        [TestCase(FieldFILTERNAME_COMPANY_SUBTYPE)]
        [TestCase(FieldFILTERNAME_COMPANY_SICCODE)]
        [TestCase(FieldFILTERNAME_COMPANY_MARKETSECTOR)]
        [TestCase(FieldFILTERNAME_COMPANY_SOURCE)]
        [TestCase(FieldFILTERNAME_COMPANY_STATUS)]
        [TestCase(FieldFILTERNAME_COMPANY_STATE)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_COUNTRY)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_GENDER)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_TITLE)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_DEPARTMENT)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_SOURCE)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_STATUS)]
        [TestCase(FieldFILTERNAME_INDIVIDUAL_STATE)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_TYPE)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_PRODUCT)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_STATUS)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_PRIORITY)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_SOURCE)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE1)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE2)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE3)]
        [TestCase(FieldFILTERNAME_SALESOPPORTUNITY_RESOLUTIONCODE4)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_TYPE)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_PRODUCT)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_STATUS)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_PRIORITY)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_SOURCE)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE1)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE2)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE3)]
        [TestCase(FieldFILTERNAME_SERVICEREQUEST_RESOLUTIONCODE4)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_TYPE)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_PRODUCT)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_STATUS)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_PRIORITY)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_SOURCE)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE1)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE2)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE3)]
        [TestCase(FieldFILTERNAME_SUPPORTINCIDENT_RESOLUTIONCODE4)]
        [TestCase(FieldFILTERNAME_WORKTICKET_TYPE)]
        [TestCase(FieldFILTERNAME_WORKTICKET_PRODUCT)]
        [TestCase(FieldFILTERNAME_WORKTICKET_STATUS)]
        [TestCase(FieldFILTERNAME_WORKTICKET_PRIORITY)]
        [TestCase(FieldFILTERNAME_WORKTICKET_SOURCE)]
        [TestCase(FieldFILTERNAME_WORKTICKET_SEVERITY)]
        [TestCase(FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE1)]
        [TestCase(FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE2)]
        [TestCase(FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE3)]
        [TestCase(FieldFILTERNAME_WORKTICKET_RESOLUTIONCODE4)]
        [TestCase(FieldFILTERNAME_EMAIL_SENT)]
        [TestCase(FieldFILTERNAME_EMAIL_PRIORITY)]
        [TestCase(FieldFILTERNAME_EMAIL_FOLLOWUP)]
        [TestCase(FieldFILTERNAME_EMAIL_DRAFT)]
        [TestCase(FieldFILTERNAME_TASK_TYPE)]
        [TestCase(FieldFILTERNAME_TASK_STATUS)]
        [TestCase(FieldFILTERNAME_TASK_PRIORITY)]
        [TestCase(FieldFILTERNAME_TASK_CATEGORY)]
        [TestCase(FieldFILTERNAME_SCRIPT_STATUS)]
        [TestCase(FieldFILTERNAME_FORECAST_STATUS)]
        [TestCase(FieldFILTERNAME_PRODUCT_STATUS)]
        [TestCase(FieldFILTERNAME_STATUSDESC)]
        [TestCase(FieldFILTERNAME_PRIORITYDESC)]
        [TestCase(FieldFILTERNAME_SOURCEDESC)]
        [TestCase(FieldFILTERNAME_TYPEDESC)]
        [TestCase(FieldFILTERNAME_PRODUCTDESC)]
        [TestCase(FieldFILTERNAME_SEVERITY)]
        [TestCase(FieldFILTERNAME_VERSIONFOUND)]
        [TestCase(FieldFILTERNAME_VERSIONFIXED)]
        [TestCase(FieldFILTERNAME_VERSIONSHIPPED)]
        [TestCase(FieldDEFAULT_BIT_TEXT)]
        [TestCase(FieldDEFAULT_DATETIME_FORMAT)]
        [TestCase(FieldCACHE_TIMESTAMP)]
        [TestCase(FieldSPACER)]
        [TestCase(FieldSPACER2)]
        [TestCase(FieldHEADER_HEIGHT)]
        [TestCase(FieldSEARCH_CRITERIA_WIDTH)]
        [TestCase(FieldLEFT_RIGHT_MARGIN)]
        [TestCase(FieldTOP_DOWN_MARGIN)]
        [TestCase(FieldIsPublicQueryLoaded)]
        [TestCase(FieldCALL_FROM)]
        [TestCase(FieldTOP_DIALOG_MARGIN)]
        [TestCase(FieldLEFT_DIALOG_MARGIN)]
        [TestCase(FieldINDIVIDUAL_WATCH)]
        [TestCase(FieldCOMPANY_WATCH)]
        [TestCase(FieldSALES_WATCH)]
        [TestCase(FieldSERVICE_WATCH)]
        [TestCase(FieldSUPPORT_WATCH)]
        [TestCase(FieldWATCH_ICON)]
        [TestCase(FieldUNWATCH_ICON)]
        [TestCase(FieldWATCH_DISABLE_ICON)]
        [TestCase(FieldLBO_COMPANY)]
        [TestCase(FieldLBO_INDIVIDUAL)]
        [TestCase(FieldLBO_INCIDENT)]
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
        public void AUT_Common_Is_Instance_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
            _commonInstance.ShouldNotBeNull();
            _commonInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Common) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Common" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _commonInstance.ShouldBeAssignableTo<Common>();
            _commonInstanceFixture.ShouldBeAssignableTo<Common>();
            CurrentInstance.ShouldBeAssignableTo<Common>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Common) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Common_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Common instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ToTitleCase) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_ToTitleCase_Static_Method_Call_Internally(Type[] types)
        {
            var methodToTitleCaseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToTitleCase, methodToTitleCaseParametersTypes);
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var name = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.ToTitleCase(name);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var name = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.ToTitleCase(name);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var name = this.CreateType<string>();
            var methodToTitleCaseParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToTitleCase = { name };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToTitleCase, methodToTitleCaseParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodToTitleCase, methodToTitleCaseParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodToTitleCase, parametersOfToTitleCase, methodToTitleCaseParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToTitleCase.ShouldNotBeNull();
            parametersOfToTitleCase.Length.ShouldBe(1);
            methodToTitleCaseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodToTitleCase, parametersOfToTitleCase, methodToTitleCaseParametersTypes));
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var name = this.CreateType<string>();
            var methodToTitleCaseParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToTitleCase = { name };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToTitleCase, methodToTitleCaseParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfToTitleCase);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToTitleCase.ShouldNotBeNull();
            parametersOfToTitleCase.Length.ShouldBe(1);
            methodToTitleCaseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var name = this.CreateType<string>();
            var methodToTitleCaseParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToTitleCase = { name };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToTitleCase, parametersOfToTitleCase, methodToTitleCaseParametersTypes);

            // Assert
            parametersOfToTitleCase.ShouldNotBeNull();
            parametersOfToTitleCase.Length.ShouldBe(1);
            methodToTitleCaseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var methodToTitleCaseParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToTitleCase, methodToTitleCaseParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToTitleCaseParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var methodToTitleCaseParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToTitleCase, methodToTitleCaseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToTitleCaseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var currentMethodInfo = this.GetMethodInfo(MethodToTitleCase, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToTitleCase) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ToTitleCase_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToTitleCase);
            var currentMethodInfo = this.GetMethodInfo(MethodToTitleCase, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetUnMaskedText_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUnMaskedTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUnMaskedText, methodGetUnMaskedTextParametersTypes);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var text = this.CreateType<string>();
            var mask = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetUnMaskedText(text, mask);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var text = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetUnMaskedText(text, mask);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var text = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetUnMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUnMaskedText = { text, mask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUnMaskedText, methodGetUnMaskedTextParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUnMaskedText, methodGetUnMaskedTextParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetUnMaskedText, parametersOfGetUnMaskedText, methodGetUnMaskedTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUnMaskedText.ShouldNotBeNull();
            parametersOfGetUnMaskedText.Length.ShouldBe(2);
            methodGetUnMaskedTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetUnMaskedText, parametersOfGetUnMaskedText, methodGetUnMaskedTextParametersTypes));
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var text = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetUnMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUnMaskedText = { text, mask };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUnMaskedText, methodGetUnMaskedTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfGetUnMaskedText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUnMaskedText.ShouldNotBeNull();
            parametersOfGetUnMaskedText.Length.ShouldBe(2);
            methodGetUnMaskedTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var text = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetUnMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUnMaskedText = { text, mask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUnMaskedText, parametersOfGetUnMaskedText, methodGetUnMaskedTextParametersTypes);

            // Assert
            parametersOfGetUnMaskedText.ShouldNotBeNull();
            parametersOfGetUnMaskedText.Length.ShouldBe(2);
            methodGetUnMaskedTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var methodGetUnMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUnMaskedText, methodGetUnMaskedTextParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUnMaskedTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var methodGetUnMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUnMaskedText, methodGetUnMaskedTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUnMaskedTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUnMaskedText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUnMaskedText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUnMaskedText_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUnMaskedText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUnMaskedText, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetMaskedText_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMaskedTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var country = this.CreateType<string>();
            var data = this.CreateType<string>();
            var mask = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetMaskedText(country, data, mask);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var country = this.CreateType<string>();
            var data = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetMaskedText(country, data, mask);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var country = this.CreateType<string>();
            var data = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetMaskedText = { country, data, mask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, methodGetMaskedTextParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetMaskedText, parametersOfGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMaskedText.ShouldNotBeNull();
            parametersOfGetMaskedText.Length.ShouldBe(3);
            methodGetMaskedTextParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetMaskedText, parametersOfGetMaskedText, methodGetMaskedTextParametersTypes));
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var country = this.CreateType<string>();
            var data = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetMaskedText = { country, data, mask };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, methodGetMaskedTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfGetMaskedText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMaskedText.ShouldNotBeNull();
            parametersOfGetMaskedText.Length.ShouldBe(3);
            methodGetMaskedTextParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var country = this.CreateType<string>();
            var data = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetMaskedText = { country, data, mask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMaskedText, parametersOfGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            parametersOfGetMaskedText.ShouldNotBeNull();
            parametersOfGetMaskedText.Length.ShouldBe(3);
            methodGetMaskedTextParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var methodGetMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMaskedTextParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var methodGetMaskedTextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMaskedTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskedText_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetMaskFormat_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMaskFormatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMaskFormat, methodGetMaskFormatParametersTypes);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var country = this.CreateType<string>();
            var mask = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetMaskFormat(country, mask);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var country = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetMaskFormat(country, mask);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var country = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetMaskFormatParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetMaskFormat = { country, mask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskFormat, methodGetMaskFormatParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMaskFormat, methodGetMaskFormatParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetMaskFormat, parametersOfGetMaskFormat, methodGetMaskFormatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMaskFormat.ShouldNotBeNull();
            parametersOfGetMaskFormat.Length.ShouldBe(2);
            methodGetMaskFormatParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetMaskFormat, parametersOfGetMaskFormat, methodGetMaskFormatParametersTypes));
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var country = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetMaskFormatParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetMaskFormat = { country, mask };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskFormat, methodGetMaskFormatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfGetMaskFormat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMaskFormat.ShouldNotBeNull();
            parametersOfGetMaskFormat.Length.ShouldBe(2);
            methodGetMaskFormatParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var country = this.CreateType<string>();
            var mask = this.CreateType<string>();
            var methodGetMaskFormatParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetMaskFormat = { country, mask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMaskFormat, parametersOfGetMaskFormat, methodGetMaskFormatParametersTypes);

            // Assert
            parametersOfGetMaskFormat.ShouldNotBeNull();
            parametersOfGetMaskFormat.Length.ShouldBe(2);
            methodGetMaskFormatParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var methodGetMaskFormatParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMaskFormat, methodGetMaskFormatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMaskFormatParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var methodGetMaskFormatParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMaskFormat, methodGetMaskFormatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMaskFormatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskFormat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMaskFormat) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetMaskFormat_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskFormat, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_CheckUIPermission_Static_Method_Call_Internally(Type[] types)
        {
            var methodCheckUIPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var resourceName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.CheckUIPermission(resourceName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var resourceName = this.CreateType<string>();
            var methodCheckUIPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckUIPermission = { resourceName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckUIPermission, parametersOfCheckUIPermission, methodCheckUIPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckUIPermission.ShouldNotBeNull();
            parametersOfCheckUIPermission.Length.ShouldBe(1);
            methodCheckUIPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodCheckUIPermission, parametersOfCheckUIPermission, methodCheckUIPermissionParametersTypes));
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var resourceName = this.CreateType<string>();
            var methodCheckUIPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckUIPermission = { resourceName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfCheckUIPermission);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckUIPermission.ShouldNotBeNull();
            parametersOfCheckUIPermission.Length.ShouldBe(1);
            methodCheckUIPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var resourceName = this.CreateType<string>();
            var methodCheckUIPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckUIPermission = { resourceName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckUIPermission, parametersOfCheckUIPermission, methodCheckUIPermissionParametersTypes);

            // Assert
            parametersOfCheckUIPermission.ShouldNotBeNull();
            parametersOfCheckUIPermission.Length.ShouldBe(1);
            methodCheckUIPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var methodCheckUIPermissionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckUIPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var methodCheckUIPermissionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckUIPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var methodCheckUIPermissionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckUIPermission, methodCheckUIPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckUIPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CheckUIPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_CheckUIPermission_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIPermission, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_IsQueryExists_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsQueryExistsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsQueryExists, methodIsQueryExistsParametersTypes);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var queryTreeCache = this.CreateType<XDocument>();
            var queryName = this.CreateType<string>();
            var folderId = this.CreateType<string>();
            var queryId = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.IsQueryExists(queryTreeCache, queryName, folderId, queryId);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var queryTreeCache = this.CreateType<XDocument>();
            var queryName = this.CreateType<string>();
            var folderId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var methodIsQueryExistsParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfIsQueryExists = { queryTreeCache, queryName, folderId, queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExists, methodIsQueryExistsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsQueryExists, methodIsQueryExistsParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsQueryExists, parametersOfIsQueryExists, methodIsQueryExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsQueryExists.ShouldNotBeNull();
            parametersOfIsQueryExists.Length.ShouldBe(4);
            methodIsQueryExistsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsQueryExists, parametersOfIsQueryExists, methodIsQueryExistsParametersTypes));
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var queryTreeCache = this.CreateType<XDocument>();
            var queryName = this.CreateType<string>();
            var folderId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var methodIsQueryExistsParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfIsQueryExists = { queryTreeCache, queryName, folderId, queryId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExists, methodIsQueryExistsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfIsQueryExists);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsQueryExists.ShouldNotBeNull();
            parametersOfIsQueryExists.Length.ShouldBe(4);
            methodIsQueryExistsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var queryTreeCache = this.CreateType<XDocument>();
            var queryName = this.CreateType<string>();
            var folderId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var methodIsQueryExistsParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfIsQueryExists = { queryTreeCache, queryName, folderId, queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsQueryExists, parametersOfIsQueryExists, methodIsQueryExistsParametersTypes);

            // Assert
            parametersOfIsQueryExists.ShouldNotBeNull();
            parametersOfIsQueryExists.Length.ShouldBe(4);
            methodIsQueryExistsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var methodIsQueryExistsParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsQueryExists, methodIsQueryExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsQueryExistsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var methodIsQueryExistsParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsQueryExists, methodIsQueryExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsQueryExistsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var methodIsQueryExistsParametersTypes = new Type[] { typeof(XDocument), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsQueryExists, methodIsQueryExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsQueryExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExists, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsQueryExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsQueryExists_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExists, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_IsValidQuery_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsValidQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsValidQuery, methodIsValidQueryParametersTypes);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var queryName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.IsValidQuery(queryName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var queryName = this.CreateType<string>();
            var methodIsValidQueryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsValidQuery = { queryName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidQuery, methodIsValidQueryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsValidQuery, methodIsValidQueryParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsValidQuery, parametersOfIsValidQuery, methodIsValidQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsValidQuery.ShouldNotBeNull();
            parametersOfIsValidQuery.Length.ShouldBe(1);
            methodIsValidQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsValidQuery, parametersOfIsValidQuery, methodIsValidQueryParametersTypes));
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var queryName = this.CreateType<string>();
            var methodIsValidQueryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsValidQuery = { queryName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidQuery, methodIsValidQueryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfIsValidQuery);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsValidQuery.ShouldNotBeNull();
            parametersOfIsValidQuery.Length.ShouldBe(1);
            methodIsValidQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var queryName = this.CreateType<string>();
            var methodIsValidQueryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsValidQuery = { queryName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsValidQuery, parametersOfIsValidQuery, methodIsValidQueryParametersTypes);

            // Assert
            parametersOfIsValidQuery.ShouldNotBeNull();
            parametersOfIsValidQuery.Length.ShouldBe(1);
            methodIsValidQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var methodIsValidQueryParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsValidQuery, methodIsValidQueryParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsValidQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var methodIsValidQueryParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsValidQuery, methodIsValidQueryParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsValidQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var methodIsValidQueryParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsValidQuery, methodIsValidQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsValidQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsValidQuery) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_IsValidQuery_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_SafeXml_Static_Method_Call_Internally(Type[] types)
        {
            var methodSafeXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSafeXml, methodSafeXmlParametersTypes);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var xmlData = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.SafeXml(xmlData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var xmlData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.SafeXml(xmlData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var xmlData = this.CreateType<string>();
            var methodSafeXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSafeXml = { xmlData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSafeXml, methodSafeXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSafeXml, methodSafeXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodSafeXml, parametersOfSafeXml, methodSafeXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSafeXml.ShouldNotBeNull();
            parametersOfSafeXml.Length.ShouldBe(1);
            methodSafeXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodSafeXml, parametersOfSafeXml, methodSafeXmlParametersTypes));
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var xmlData = this.CreateType<string>();
            var methodSafeXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSafeXml = { xmlData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSafeXml, methodSafeXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfSafeXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSafeXml.ShouldNotBeNull();
            parametersOfSafeXml.Length.ShouldBe(1);
            methodSafeXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var xmlData = this.CreateType<string>();
            var methodSafeXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSafeXml = { xmlData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSafeXml, parametersOfSafeXml, methodSafeXmlParametersTypes);

            // Assert
            parametersOfSafeXml.ShouldNotBeNull();
            parametersOfSafeXml.Length.ShouldBe(1);
            methodSafeXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var methodSafeXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSafeXml, methodSafeXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSafeXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var methodSafeXmlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSafeXml, methodSafeXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSafeXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSafeXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SafeXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_SafeXml_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSafeXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSafeXml, 0);
            const int parametersCount = 1;

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