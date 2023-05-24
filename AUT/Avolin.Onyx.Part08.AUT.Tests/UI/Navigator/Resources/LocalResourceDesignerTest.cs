using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Resources;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.Resources
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Resources.LocalResource" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Resources"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LocalResourceDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LocalResourceNonPublicTypeName" />) using
        ///     Using a public type <see cref="CMLocalizedResources" /> to
        ///     create a non-public type.
        /// </summary>
        public LocalResourceDesignerTest() : base(publicType: typeof(CMLocalizedResources), classNameWithNamespace: LocalResourceNonPublicTypeName)
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

        private Type _localResourceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string LocalResourceNonPublicTypeName = "Onyx.UI.Navigator.Resources.LocalResource";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _localResourceInstance;
        private object _localResourceInstanceFixture;

        #region General Initializer : Class (LocalResource) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LocalResource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _localResourceInstanceFixture = this.CreateNonPublicType(LocalResourceNonPublicTypeName);
            _localResourceInstance = _localResourceInstanceFixture;
            CurrentInstance = _localResourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LocalResource) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyCaption_Batch = "Caption_Batch";
        private const string PropertyCaption_ConfigureResultGrid = "Caption_ConfigureResultGrid";
        private const string PropertyCaption_ConfigureSearchCriteria = "Caption_ConfigureSearchCriteria";
        private const string PropertyCaption_DefaultTab = "Caption_DefaultTab";
        private const string PropertyCaption_Export = "Caption_Export";
        private const string PropertyCaption_MB = "Caption_MB";
        private const string PropertyCaption_Merge = "Caption_Merge";
        private const string PropertyCaption_NewQuota = "Caption_NewQuota";
        private const string PropertyCaption_Print = "Caption_Print";
        private const string PropertyCaption_QuotaAllocated = "Caption_QuotaAllocated";
        private const string PropertyCaption_QuotaAvaiable = "Caption_QuotaAvaiable";
        private const string PropertyCaption_QuotaNote = "Caption_QuotaNote";
        private const string PropertyCaption_QuotaUsed = "Caption_QuotaUsed";
        private const string PropertyData_EmailNoDisplayName = "Data_EmailNoDisplayName";
        private const string PropertyData_EmailYesDisplayName = "Data_EmailYesDisplayName";
        private const string PropertyData_EmptyDisplay = "Data_EmptyDisplay";
        private const string PropertyData_Female = "Data_Female";
        private const string PropertyData_Male = "Data_Male";
        private const string PropertyData_NotEmptyDisplay = "Data_NotEmptyDisplay";
        private const string PropertyError_BatchUpdateSave = "Error_BatchUpdateSave";
        private const string PropertyError_ConnectionFail = "Error_ConnectionFail";
        private const string PropertyError_CSVFilter = "Error_CSVFilter";
        private const string PropertyError_ExportCSV = "Error_ExportCSV";
        private const string PropertyError_InLineEdit = "Error_InLineEdit";
        private const string PropertyError_InvalidLogin = "Error_InvalidLogin";
        private const string PropertyError_MandatoryCriteria = "Error_MandatoryCriteria";
        private const string PropertyError_SearchQueryLimit = "Error_SearchQueryLimit";
        private const string PropertyHeader_Caption_Department = "Header_Caption_Department";
        private const string PropertyHeader_Caption_Id = "Header_Caption_Id";
        private const string PropertyHeader_Caption_Username = "Header_Caption_Username";
        private const string PropertyHelptext_ConfigureResultGrid = "Helptext_ConfigureResultGrid";
        private const string PropertyHelptext_ConfigureSearchCriteria = "Helptext_ConfigureSearchCriteria";
        private const string PropertyLabel_ActualDate = "Label_ActualDate";
        private const string PropertyLabel_And = "Label_And";
        private const string PropertyLabel_Appointment = "Label_Appointment";
        private const string PropertyLabel_BatchUpdateRecallDate = "Label_BatchUpdateRecallDate";
        private const string PropertyLabel_Caching = "Label_Caching";
        private const string PropertyLabel_CampiagnTreeRootItem = "Label_CampiagnTreeRootItem";
        private const string PropertyLabel_Cancel = "Label_Cancel";
        private const string PropertyLabel_Caption = "Label_Caption";
        private const string PropertyLabel_ClientSummary = "Label_ClientSummary";
        
        private const string PropertyLabel_CollapseButton = "Label_CollapseButton";
        private const string PropertyLabel_Company = "Label_Company";
        private const string PropertyLabel_Continue = "Label_Continue";
        private const string PropertyLabel_Custom = "Label_Custom";
        private const string PropertyLabel_DoMore = "Label_DoMore";
        private const string PropertyLabel_Editable = "Label_Editable";
        private const string PropertyLabel_Email = "Label_Email";
        private const string PropertyLabel_Empty = "Label_Empty";
        private const string PropertyLabel_ExpandButton = "Label_ExpandButton";
        private const string PropertyLabel_FieldName = "Label_FieldName";
        private const string PropertyLabel_fileLink = "Label_fileLink";
        private const string PropertyLabel_Forecast = "Label_Forecast";
        private const string PropertyLabel_FromDate = "Label_FromDate";
        private const string PropertyLabel_IncidentSummary = "Label_IncidentSummary";
        private const string PropertyLabel_IncreaseQuota = "Label_IncreaseQuota";
        private const string PropertyLabel_Individual = "Label_Individual";
        private const string PropertyLabel_Is = "Label_Is";
        private const string PropertyLabel_IsBookMark = "Label_IsBookMark";
        private const string PropertyLabel_IsDate = "Label_IsDate";
        private const string PropertyLabel_IsHomePageQuery = "Label_IsHomePageQuery";
        private const string PropertyLabel_IsMobileBookMark = "Label_IsMobileBookMark";
        private const string PropertyLabel_Loading = "Label_Loading";
        private const string PropertyLabel_LoginOK = "Label_LoginOK";
        private const string PropertyLabel_MaxRows = "Label_MaxRows";
        private const string PropertyLabel_MessageTitle = "Label_MessageTitle";
        private const string PropertyLabel_NewFolder = "Label_NewFolder";
        private const string PropertyLabel_No = "Label_No";
        private const string PropertyLabel_Ok = "Label_Ok";
        private const string PropertyLabel_PageSize = "Label_PageSize";
        private const string PropertyLabel_Password = "Label_Password";
        private const string PropertyLabel_PrivateFolder = "Label_PrivateFolder";
        private const string PropertyLabel_Product = "Label_Product";
        private const string PropertyLabel_ProductTreeRootItem = "Label_ProductTreeRootItem";
        private const string PropertyLabel_Profile = "Label_Profile";
        private const string PropertyLabel_Property = "Label_Property";
        private const string PropertyLabel_PublicFolder = "Label_PublicFolder";
        private const string PropertyLabel_Queryname = "Label_Queryname";
        private const string PropertyLabel_RecallDate = "Label_RecallDate";
        private const string PropertyLabel_RecallDateDelete = "Label_RecallDateDelete";
        private const string PropertyLabel_RecallDateUpdate = "Label_RecallDateUpdate";
        private const string PropertyLabel_RecallTime = "Label_RecallTime";
        private const string PropertyLabel_Required = "Label_Required";
        private const string PropertyLabel_ResultAdminConsole = "Label_ResultAdminConsole";
        private const string PropertyLabel_SalesOpportunity = "Label_SalesOpportunity";
        private const string PropertyLabel_SalesTask = "Label_SalesTask";
        private const string PropertyLabel_Save = "Label_Save";
        private const string PropertyLabel_SaveAs = "Label_SaveAs";
        private const string PropertyLabel_SavedQueries = "Label_SavedQueries";
        private const string PropertyLabel_Script = "Label_Script";
        private const string PropertyLabel_ScriptTreeRootItem = "Label_ScriptTreeRootItem";
        private const string PropertyLabel_SearchAdminConsole = "Label_SearchAdminConsole";
        private const string PropertyLabel_SearchCriteria = "Label_SearchCriteria";
        private const string PropertyLabel_SearchFor = "Label_SearchFor";
        private const string PropertyLabel_SearchResults = "Label_SearchResults";
        private const string PropertyLabel_SearchType = "Label_SearchType";
        private const string PropertyLabel_ServiceRequest = "Label_ServiceRequest";
        private const string PropertyLabel_ServiceTask = "Label_ServiceTask";
        private const string PropertyLabel_SortBy = "Label_SortBy";
        private const string PropertyLabel_SupportIncident = "Label_SupportIncident";
        private const string PropertyLabel_SupportTask = "Label_SupportTask";
        private const string PropertyLabel_Task = "Label_Task";
        private const string PropertyLabel_ThenBy = "Label_ThenBy";
        private const string PropertyLabel_ToDate = "Label_ToDate";
        private const string PropertyLabel_UIResource = "Label_UIResource";
        private const string PropertyLabel_UserID = "Label_UserID";
        private const string PropertyLabel_UserTreeRootItem = "Label_UserTreeRootItem";
        private const string PropertyLabel_WorkTicket = "Label_WorkTicket";
        private const string PropertyLabel_Yes = "Label_Yes";
        private const string PropertyMessage_AccessControlListFailure = "Message_AccessControlListFailure";
        private const string PropertyMessage_AlreadyQueryDeleted = "Message_AlreadyQueryDeleted";
        private const string PropertyMessage_ApplicationInitFail = "Message_ApplicationInitFail";
        private const string PropertyMessage_BatchUpdate = "Message_BatchUpdate";
        private const string PropertyMessage_BatchUpdateSaveFailure = "Message_BatchUpdateSaveFailure";
        private const string PropertyMessage_BatchUpdateTaskAlreadyExist = "Message_BatchUpdateTaskAlreadyExist";
        private const string PropertyMessage_CaptionBlankAlert = "Message_CaptionBlankAlert";
        private const string PropertyMessage_DefaultListEmpty = "Message_DefaultListEmpty";
        private const string PropertyMessage_DeleteFolderConfirmation = "Message_DeleteFolderConfirmation";
        private const string PropertyMessage_DeleteQueryConfirmation = "Message_DeleteQueryConfirmation";
        private const string PropertyMessage_ElementNotFound = "Message_ElementNotFound";
        private const string PropertyMessage_EnterIntegerValue = "Message_EnterIntegerValue";
        private const string PropertyMessage_EnterQueryName = "Message_EnterQueryName";
        private const string PropertyMessage_EnterValueForMaxRows = "Message_EnterValueForMaxRows";
        private const string PropertyMessage_EntityNotFound = "Message_EntityNotFound";
        private const string PropertyMessage_ExceedMaxPageSizeLimitError = "Message_ExceedMaxPageSizeLimitError";
        private const string PropertyMessage_ExceedMaxRecordLimitError = "Message_ExceedMaxRecordLimitError";
        private const string PropertyMessage_ExceedMaxRecordLimitWarning = "Message_ExceedMaxRecordLimitWarning";
        private const string PropertyMessage_FieldsMovedDisabledList = "Message_FieldsMovedDisabledList";
        private const string PropertyMessage_Grouping = "Message_Grouping";
        private const string PropertyMessage_HeaderListEmpty = "Message_HeaderListEmpty";
        private const string PropertyMessage_HowTouse = "Message_HowTouse";
        private const string PropertyMessage_IncorrectDataFormat = "Message_IncorrectDataFormat";
        private const string PropertyMessage_InvalidPropertyName = "Message_InvalidPropertyName";
        private const string PropertyMessage_LoadingQuery = "Message_LoadingQuery";
        private const string PropertyMessage_MergeRecordAlert = "Message_MergeRecordAlert";
        private const string PropertyMessage_MergeRecordConfirmation = "Message_MergeRecordConfirmation";
        private const string PropertyMessage_MergeRecordSelect = "Message_MergeRecordSelect";
        private const string PropertyMessage_MergeRecordSuccess = "Message_MergeRecordSuccess";
        private const string PropertyMessage_MobileBookMarkError = "Message_MobileBookMarkError";
        private const string PropertyMessage_MobileBookmarkValidationFailure = "Message_MobileBookmarkValidationFailure";
        private const string PropertyMessage_ModelUnavailable = "Message_ModelUnavailable";
        private const string PropertyMessage_ModulePrivilegeFailure = "Message_ModulePrivilegeFailure";
        private const string PropertyMessage_MoreRecordWarning = "Message_MoreRecordWarning";
        private const string PropertyMessage_NoRecords = "Message_NoRecords";
        private const string PropertyMessage_NothingToSave = "Message_NothingToSave";
        private const string PropertyMessage_NullElement = "Message_NullElement";
        private const string PropertyMessage_NullFieldId = "Message_NullFieldId";
        private const string PropertyMessage_NullFieldInfo = "Message_NullFieldInfo";
        private const string PropertyMessage_NullFieldName = "Message_NullFieldName";
        private const string PropertyMessage_NullMappings = "Message_NullMappings";
        private const string PropertyMessage_NullName = "Message_NullName";
        private const string PropertyMessage_NullNode = "Message_NullNode";
        private const string PropertyMessage_NullUpdateXml = "Message_NullUpdateXml";
        private const string PropertyMessage_NullValue = "Message_NullValue";
        private const string PropertyMessage_ParentDropOnChild = "Message_ParentDropOnChild";
        private const string PropertyMessage_ProcessingSaveRequest = "Message_ProcessingSaveRequest";
        private const string PropertyMessage_PublicFolderDelete = "Message_PublicFolderDelete";
        private const string PropertyMessage_PublicQueryDelete = "Message_PublicQueryDelete";
        private const string PropertyMessage_PublicQueryOwner = "Message_PublicQueryOwner";
        private const string PropertyMessage_QueryAlreadyExists = "Message_QueryAlreadyExists";
        private const string PropertyMessage_QueryDeleted = "Message_QueryDeleted";
        private const string PropertyMessage_QueryFolderMove = "Message_QueryFolderMove";
        private const string PropertyMessage_QueryNotExist = "Message_QueryNotExist";
        private const string PropertyMessage_QuerySaved = "Message_QuerySaved";
        private const string PropertyMessage_QuotaError = "Message_QuotaError";
        private const string PropertyMessage_QuotaSuccess = "Message_QuotaSuccess";
        private const string PropertyMessage_ResetAlert = "Message_ResetAlert";
        private const string PropertyMessage_ResetSave = "Message_ResetSave";
        private const string PropertyMessage_ResultGridAdminLoadFailure = "Message_ResultGridAdminLoadFailure";
        private const string PropertyMessage_SaveAlert = "Message_SaveAlert";
        private const string PropertyMessage_SaveConfirmation = "Message_SaveConfirmation";
        private const string PropertyMessage_SaveFailure = "Message_SaveFailure";
        private const string PropertyMessage_SaveQuerySelectFolder = "Message_SaveQuerySelectFolder";
        private const string PropertyMessage_SaveSuccess = "Message_SaveSuccess";
        private const string PropertyMessage_SearchAdminLoadFailure = "Message_SearchAdminLoadFailure";
        private const string PropertyMessage_SearchFilterLoadFail = "Message_SearchFilterLoadFail";
        private const string PropertyMessage_SelectEntity = "Message_SelectEntity";
        private const string PropertyMessage_SelectFolder = "Message_SelectFolder";
        private const string PropertyMessage_SelectFolderQueryToDelete = "Message_SelectFolderQueryToDelete";
        private const string PropertyMessage_SelectItemToEdit = "Message_SelectItemToEdit";
        private const string PropertyMessage_SortOrderSameValue = "Message_SortOrderSameValue";
        private const string PropertyMessage_SupplyCriteria = "Message_SupplyCriteria";
        private const string PropertyMessage_TotalNoofRecords = "Message_TotalNoofRecords";
        private const string PropertyMessage_UnWatch = "Message_UnWatch";
        private const string PropertyMessage_UpdatePublicQuery = "Message_UpdatePublicQuery";
        private const string PropertyMessage_UpdateQuery = "Message_UpdateQuery";
        private const string PropertyMessage_Watch = "Message_Watch";
        private const string PropertyTitle_Available = "Title_Available";
        private const string PropertyTitle_BatchUpdate = "Title_BatchUpdate";
        private const string PropertyTitle_Detail = "Title_Detail";
        private const string PropertyTitle_Disabled = "Title_Disabled";
        private const string PropertyTitle_EditField = "Title_EditField";
        private const string PropertyTitle_GridUserPicker_Description = "Title_GridUserPicker_Description";
        private const string PropertyTitle_GridUserPicker_ID = "Title_GridUserPicker_ID";
        private const string PropertyTitle_GridUserPicker_Name = "Title_GridUserPicker_Name";
        private const string PropertyTitle_Header = "Title_Header";
        private const string PropertyTitle_PleaseWait = "Title_PleaseWait";
        private const string PropertyTitle_QueryExplorer = "Title_QueryExplorer";
        private const string PropertyTitle_SaveFilter = "Title_SaveFilter";
        private const string PropertyTitle_Selected = "Title_Selected";
        private const string PropertyTitle_ServiceException = "Title_ServiceException";
        private const string PropertyTitle_UnabelResolve = "Title_UnabelResolve";
        private const string PropertyTitle_UserPicker = "Title_UserPicker";
        private const string PropertyToolTip_ActionMenu = "ToolTip_ActionMenu";
        private const string PropertyToolTip_ApplyChanges = "ToolTip_ApplyChanges";
        private const string PropertyToolTip_BatchCancel = "ToolTip_BatchCancel";
        private const string PropertyToolTip_BatchSave = "ToolTip_BatchSave";
        private const string PropertyToolTip_CancelExit = "ToolTip_CancelExit";
        private const string PropertyToolTip_ClearCriteria = "ToolTip_ClearCriteria";
        private const string PropertyToolTip_CloseSummary = "ToolTip_CloseSummary";
        private const string PropertyToolTip_ConfigureMenu = "ToolTip_ConfigureMenu";
        private const string PropertyToolTip_ConfigureRLC = "ToolTip_ConfigureRLC";
        private const string PropertyToolTip_Copyright_Warning = "ToolTip_Copyright_Warning";
        private const string PropertyToolTip_CreateBookMark = "ToolTip_CreateBookMark";
        private const string PropertyToolTip_CreateMobileBookMark = "ToolTip_CreateMobileBookMark";
        private const string PropertyToolTip_DeleteBookMark = "ToolTip_DeleteBookMark";
        private const string PropertyToolTip_DeleteFolderQuery = "ToolTip_DeleteFolderQuery";
        private const string PropertyToolTip_DeleteMobileBookMark = "ToolTip_DeleteMobileBookMark";
        private const string PropertyToolTip_EditField = "ToolTip_EditField";
        private const string PropertyToolTip_FullScreen = "ToolTip_FullScreen";
        private const string PropertyToolTip_ListView = "ToolTip_ListView";
        private const string PropertyToolTip_MergeItems = "ToolTip_MergeItems";
        private const string PropertyToolTip_NewFolder = "ToolTip_NewFolder";
        private const string PropertyToolTip_NormalView = "ToolTip_NormalView";
        private const string PropertyToolTip_OpenSavedQuery = "ToolTip_OpenSavedQuery";
        private const string PropertyToolTip_RecordsSelected = "ToolTip_RecordsSelected";
        private const string PropertyToolTip_RefreshResults = "ToolTip_RefreshResults";
        private const string PropertyToolTip_ResetDefault = "ToolTip_ResetDefault";
        private const string PropertyToolTip_Restore = "ToolTip_Restore";
        private const string PropertyToolTip_ReturnSearch = "ToolTip_ReturnSearch";
        private const string PropertyToolTip_RunQuery = "ToolTip_RunQuery";
        private const string PropertyToolTip_Save = "ToolTip_Save";
        private const string PropertyToolTip_SaveFieldProperty = "ToolTip_SaveFieldProperty";
        private const string PropertyToolTip_SaveQuery = "ToolTip_SaveQuery";
        private const string PropertyToolTip_SaveSetting = "ToolTip_SaveSetting";
        private const string PropertyToolTip_SelectFieldsQuery = "ToolTip_SelectFieldsQuery";
        private const string PropertyToolTip_SortAscending = "ToolTip_SortAscending";
        private const string PropertyToolTip_SortDescending = "ToolTip_SortDescending";
        private const string PropertyToolTip_TreeView = "ToolTip_TreeView";
        private const string PropertyTooltip_UnWatch = "Tooltip_UnWatch";
        private const string PropertyToolTip_ViewSummary = "ToolTip_ViewSummary";
        private const string PropertyTooltip_Watch = "Tooltip_Watch";
        private const string PropertyTooltip_WatchDisabled = "Tooltip_WatchDisabled";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (LocalResource)

        #region General Initializer : Class (LocalResource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LocalResource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LocalResourceDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LocalResource) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="LocalResource" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyCaption_Batch)]
        [TestCase(PropertyCaption_ConfigureResultGrid)]
        [TestCase(PropertyCaption_ConfigureSearchCriteria)]
        [TestCase(PropertyCaption_DefaultTab)]
        [TestCase(PropertyCaption_Export)]
        [TestCase(PropertyCaption_MB)]
        [TestCase(PropertyCaption_Merge)]
        [TestCase(PropertyCaption_NewQuota)]
        [TestCase(PropertyCaption_Print)]
        [TestCase(PropertyCaption_QuotaAllocated)]
        [TestCase(PropertyCaption_QuotaAvaiable)]
        [TestCase(PropertyCaption_QuotaNote)]
        [TestCase(PropertyCaption_QuotaUsed)]
        [TestCase(PropertyData_EmailNoDisplayName)]
        [TestCase(PropertyData_EmailYesDisplayName)]
        [TestCase(PropertyData_EmptyDisplay)]
        [TestCase(PropertyData_Female)]
        [TestCase(PropertyData_Male)]
        [TestCase(PropertyData_NotEmptyDisplay)]
        [TestCase(PropertyError_BatchUpdateSave)]
        [TestCase(PropertyError_ConnectionFail)]
        [TestCase(PropertyError_CSVFilter)]
        [TestCase(PropertyError_ExportCSV)]
        [TestCase(PropertyError_InLineEdit)]
        [TestCase(PropertyError_InvalidLogin)]
        [TestCase(PropertyError_MandatoryCriteria)]
        [TestCase(PropertyError_SearchQueryLimit)]
        [TestCase(PropertyHeader_Caption_Department)]
        [TestCase(PropertyHeader_Caption_Id)]
        [TestCase(PropertyHeader_Caption_Username)]
        [TestCase(PropertyHelptext_ConfigureResultGrid)]
        [TestCase(PropertyHelptext_ConfigureSearchCriteria)]
        [TestCase(PropertyLabel_ActualDate)]
        [TestCase(PropertyLabel_And)]
        [TestCase(PropertyLabel_Appointment)]
        [TestCase(PropertyLabel_BatchUpdateRecallDate)]
        [TestCase(PropertyLabel_Caching)]
        [TestCase(PropertyLabel_CampiagnTreeRootItem)]
        [TestCase(PropertyLabel_Cancel)]
        [TestCase(PropertyLabel_Caption)]
        [TestCase(PropertyLabel_ClientSummary)]
        [TestCase(PropertyLabel_CollapseButton)]
        [TestCase(PropertyLabel_Company)]
        [TestCase(PropertyLabel_Continue)]
        [TestCase(PropertyLabel_Custom)]
        [TestCase(PropertyLabel_DoMore)]
        [TestCase(PropertyLabel_Editable)]
        [TestCase(PropertyLabel_Email)]
        [TestCase(PropertyLabel_Empty)]
        [TestCase(PropertyLabel_ExpandButton)]
        [TestCase(PropertyLabel_FieldName)]
        [TestCase(PropertyLabel_fileLink)]
        [TestCase(PropertyLabel_Forecast)]
        [TestCase(PropertyLabel_FromDate)]
        [TestCase(PropertyLabel_IncidentSummary)]
        [TestCase(PropertyLabel_IncreaseQuota)]
        [TestCase(PropertyLabel_Individual)]
        [TestCase(PropertyLabel_Is)]
        [TestCase(PropertyLabel_IsBookMark)]
        [TestCase(PropertyLabel_IsDate)]
        [TestCase(PropertyLabel_IsHomePageQuery)]
        [TestCase(PropertyLabel_IsMobileBookMark)]
        [TestCase(PropertyLabel_Loading)]
        [TestCase(PropertyLabel_LoginOK)]
        [TestCase(PropertyLabel_MaxRows)]
        [TestCase(PropertyLabel_MessageTitle)]
        [TestCase(PropertyLabel_NewFolder)]
        [TestCase(PropertyLabel_No)]
        [TestCase(PropertyLabel_Ok)]
        [TestCase(PropertyLabel_Password)]
        [TestCase(PropertyLabel_PrivateFolder)]
        [TestCase(PropertyLabel_Product)]
        [TestCase(PropertyLabel_ProductTreeRootItem)]
        [TestCase(PropertyLabel_Profile)]
        [TestCase(PropertyLabel_Property)]
        [TestCase(PropertyLabel_PublicFolder)]
        [TestCase(PropertyLabel_Queryname)]
        [TestCase(PropertyLabel_RecallDate)]
        [TestCase(PropertyLabel_RecallDateDelete)]
        [TestCase(PropertyLabel_RecallDateUpdate)]
        [TestCase(PropertyLabel_RecallTime)]
        [TestCase(PropertyLabel_Required)]
        [TestCase(PropertyLabel_ResultAdminConsole)]
        [TestCase(PropertyLabel_SalesOpportunity)]
        [TestCase(PropertyLabel_SalesTask)]
        [TestCase(PropertyLabel_Save)]
        [TestCase(PropertyLabel_SaveAs)]
        [TestCase(PropertyLabel_SavedQueries)]
        [TestCase(PropertyLabel_Script)]
        [TestCase(PropertyLabel_ScriptTreeRootItem)]
        [TestCase(PropertyLabel_SearchAdminConsole)]
        [TestCase(PropertyLabel_SearchCriteria)]
        [TestCase(PropertyLabel_SearchFor)]
        [TestCase(PropertyLabel_SearchResults)]
        [TestCase(PropertyLabel_SearchType)]
        [TestCase(PropertyLabel_ServiceRequest)]
        [TestCase(PropertyLabel_ServiceTask)]
        [TestCase(PropertyLabel_SortBy)]
        [TestCase(PropertyLabel_SupportIncident)]
        [TestCase(PropertyLabel_SupportTask)]
        [TestCase(PropertyLabel_Task)]
        [TestCase(PropertyLabel_ThenBy)]
        [TestCase(PropertyLabel_ToDate)]
        [TestCase(PropertyLabel_UIResource)]
        [TestCase(PropertyLabel_UserID)]
        [TestCase(PropertyLabel_UserTreeRootItem)]
        [TestCase(PropertyLabel_WorkTicket)]
        [TestCase(PropertyLabel_Yes)]
        [TestCase(PropertyMessage_AccessControlListFailure)]
        [TestCase(PropertyMessage_AlreadyQueryDeleted)]
        [TestCase(PropertyMessage_ApplicationInitFail)]
        [TestCase(PropertyMessage_BatchUpdate)]
        [TestCase(PropertyMessage_BatchUpdateSaveFailure)]
        [TestCase(PropertyMessage_BatchUpdateTaskAlreadyExist)]
        [TestCase(PropertyMessage_CaptionBlankAlert)]
        [TestCase(PropertyMessage_DefaultListEmpty)]
        [TestCase(PropertyMessage_DeleteFolderConfirmation)]
        [TestCase(PropertyMessage_DeleteQueryConfirmation)]
        [TestCase(PropertyMessage_ElementNotFound)]
        [TestCase(PropertyMessage_EnterIntegerValue)]
        [TestCase(PropertyMessage_EnterQueryName)]
        [TestCase(PropertyMessage_EnterValueForMaxRows)]
        [TestCase(PropertyMessage_EntityNotFound)]
        [TestCase(PropertyMessage_ExceedMaxRecordLimitError)]
        [TestCase(PropertyMessage_ExceedMaxRecordLimitWarning)]
        [TestCase(PropertyMessage_FieldsMovedDisabledList)]
        [TestCase(PropertyMessage_Grouping)]
        [TestCase(PropertyMessage_HeaderListEmpty)]
        [TestCase(PropertyMessage_HowTouse)]
        [TestCase(PropertyMessage_IncorrectDataFormat)]
        [TestCase(PropertyMessage_InvalidPropertyName)]
        [TestCase(PropertyMessage_LoadingQuery)]
        [TestCase(PropertyMessage_MergeRecordAlert)]
        [TestCase(PropertyMessage_MergeRecordConfirmation)]
        [TestCase(PropertyMessage_MergeRecordSelect)]
        [TestCase(PropertyMessage_MergeRecordSuccess)]
        [TestCase(PropertyMessage_MobileBookMarkError)]
        [TestCase(PropertyMessage_MobileBookmarkValidationFailure)]
        [TestCase(PropertyMessage_ModelUnavailable)]
        [TestCase(PropertyMessage_ModulePrivilegeFailure)]
        [TestCase(PropertyMessage_MoreRecordWarning)]
        [TestCase(PropertyMessage_NoRecords)]
        [TestCase(PropertyMessage_NothingToSave)]
        [TestCase(PropertyMessage_NullElement)]
        [TestCase(PropertyMessage_NullFieldId)]
        [TestCase(PropertyMessage_NullFieldInfo)]
        [TestCase(PropertyMessage_NullFieldName)]
        [TestCase(PropertyMessage_NullMappings)]
        [TestCase(PropertyMessage_NullName)]
        [TestCase(PropertyMessage_NullNode)]
        [TestCase(PropertyMessage_NullUpdateXml)]
        [TestCase(PropertyMessage_NullValue)]
        [TestCase(PropertyMessage_ParentDropOnChild)]
        [TestCase(PropertyMessage_ProcessingSaveRequest)]
        [TestCase(PropertyMessage_PublicFolderDelete)]
        [TestCase(PropertyMessage_PublicQueryDelete)]
        [TestCase(PropertyMessage_PublicQueryOwner)]
        [TestCase(PropertyMessage_QueryAlreadyExists)]
        [TestCase(PropertyMessage_QueryDeleted)]
        [TestCase(PropertyMessage_QueryFolderMove)]
        [TestCase(PropertyMessage_QueryNotExist)]
        [TestCase(PropertyMessage_QuerySaved)]
        [TestCase(PropertyMessage_QuotaError)]
        [TestCase(PropertyMessage_QuotaSuccess)]
        [TestCase(PropertyMessage_ResetAlert)]
        [TestCase(PropertyMessage_ResetSave)]
        [TestCase(PropertyMessage_ResultGridAdminLoadFailure)]
        [TestCase(PropertyMessage_SaveAlert)]
        [TestCase(PropertyMessage_SaveConfirmation)]
        [TestCase(PropertyMessage_SaveFailure)]
        [TestCase(PropertyMessage_SaveQuerySelectFolder)]
        [TestCase(PropertyMessage_SaveSuccess)]
        [TestCase(PropertyMessage_SearchAdminLoadFailure)]
        [TestCase(PropertyMessage_SearchFilterLoadFail)]
        [TestCase(PropertyMessage_SelectEntity)]
        [TestCase(PropertyMessage_SelectFolder)]
        [TestCase(PropertyMessage_SelectFolderQueryToDelete)]
        [TestCase(PropertyMessage_SelectItemToEdit)]
        [TestCase(PropertyMessage_SortOrderSameValue)]
        [TestCase(PropertyMessage_SupplyCriteria)]
        [TestCase(PropertyMessage_TotalNoofRecords)]
        [TestCase(PropertyMessage_UnWatch)]
        [TestCase(PropertyMessage_UpdatePublicQuery)]
        [TestCase(PropertyMessage_UpdateQuery)]
        [TestCase(PropertyMessage_Watch)]
        [TestCase(PropertyTitle_Available)]
        [TestCase(PropertyTitle_BatchUpdate)]
        [TestCase(PropertyTitle_Detail)]
        [TestCase(PropertyTitle_Disabled)]
        [TestCase(PropertyTitle_EditField)]
        [TestCase(PropertyTitle_GridUserPicker_Description)]
        [TestCase(PropertyTitle_GridUserPicker_ID)]
        [TestCase(PropertyTitle_GridUserPicker_Name)]
        [TestCase(PropertyTitle_Header)]
        [TestCase(PropertyTitle_PleaseWait)]
        [TestCase(PropertyTitle_QueryExplorer)]
        [TestCase(PropertyTitle_SaveFilter)]
        [TestCase(PropertyTitle_Selected)]
        [TestCase(PropertyTitle_ServiceException)]
        [TestCase(PropertyTitle_UnabelResolve)]
        [TestCase(PropertyTitle_UserPicker)]
        [TestCase(PropertyToolTip_ActionMenu)]
        [TestCase(PropertyToolTip_ApplyChanges)]
        [TestCase(PropertyToolTip_BatchCancel)]
        [TestCase(PropertyToolTip_BatchSave)]
        [TestCase(PropertyToolTip_ClearCriteria)]
        [TestCase(PropertyToolTip_ConfigureMenu)]
        [TestCase(PropertyToolTip_ConfigureRLC)]
        [TestCase(PropertyToolTip_Copyright_Warning)]
        [TestCase(PropertyToolTip_CreateBookMark)]
        [TestCase(PropertyToolTip_CreateMobileBookMark)]
        [TestCase(PropertyToolTip_DeleteBookMark)]
        [TestCase(PropertyToolTip_DeleteFolderQuery)]
        [TestCase(PropertyToolTip_DeleteMobileBookMark)]
        [TestCase(PropertyToolTip_EditField)]
        [TestCase(PropertyToolTip_FullScreen)]
        [TestCase(PropertyToolTip_ListView)]
        [TestCase(PropertyToolTip_MergeItems)]
        [TestCase(PropertyToolTip_NewFolder)]
        [TestCase(PropertyToolTip_NormalView)]
        [TestCase(PropertyToolTip_OpenSavedQuery)]
        [TestCase(PropertyToolTip_RecordsSelected)]
        [TestCase(PropertyToolTip_RefreshResults)]
        [TestCase(PropertyToolTip_ResetDefault)]
        [TestCase(PropertyToolTip_Restore)]
        [TestCase(PropertyToolTip_ReturnSearch)]
        [TestCase(PropertyToolTip_RunQuery)]
        [TestCase(PropertyToolTip_Save)]
        [TestCase(PropertyToolTip_SaveFieldProperty)]
        [TestCase(PropertyToolTip_SaveQuery)]
        [TestCase(PropertyToolTip_SaveSetting)]
        [TestCase(PropertyToolTip_SelectFieldsQuery)]
        [TestCase(PropertyToolTip_SortAscending)]
        [TestCase(PropertyToolTip_SortDescending)]
        [TestCase(PropertyToolTip_TreeView)]
        [TestCase(PropertyTooltip_UnWatch)]
        [TestCase(PropertyToolTip_ViewSummary)]
        [TestCase(PropertyTooltip_Watch)]
        [TestCase(PropertyTooltip_WatchDisabled)]
        [Category("AUT Property")]
        public void AUT_LocalResourceDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (LocalResource) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LocalResource" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LocalResourceDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LocalResource) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LocalResource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldresourceMan)]
        [TestCase(FieldresourceCulture)]
        [Category("AUT Fields")]
        public void AUT_LocalResourceDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (LocalResource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LocalResource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LocalResourceDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (LocalResource) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyCaption_Batch)]
        [TestCase(PropertyCaption_ConfigureResultGrid)]
        [TestCase(PropertyCaption_ConfigureSearchCriteria)]
        [TestCase(PropertyCaption_DefaultTab)]
        [TestCase(PropertyCaption_Export)]
        [TestCase(PropertyCaption_MB)]
        [TestCase(PropertyCaption_Merge)]
        [TestCase(PropertyCaption_NewQuota)]
        [TestCase(PropertyCaption_Print)]
        [TestCase(PropertyCaption_QuotaAllocated)]
        [TestCase(PropertyCaption_QuotaAvaiable)]
        [TestCase(PropertyCaption_QuotaNote)]
        [TestCase(PropertyCaption_QuotaUsed)]
        [TestCase(PropertyData_EmailNoDisplayName)]
        [TestCase(PropertyData_EmailYesDisplayName)]
        [TestCase(PropertyData_EmptyDisplay)]
        [TestCase(PropertyData_Female)]
        [TestCase(PropertyData_Male)]
        [TestCase(PropertyData_NotEmptyDisplay)]
        [TestCase(PropertyError_BatchUpdateSave)]
        [TestCase(PropertyError_ConnectionFail)]
        [TestCase(PropertyError_CSVFilter)]
        [TestCase(PropertyError_ExportCSV)]
        [TestCase(PropertyError_InLineEdit)]
        [TestCase(PropertyError_InvalidLogin)]
        [TestCase(PropertyError_MandatoryCriteria)]
        [TestCase(PropertyError_SearchQueryLimit)]
        [TestCase(PropertyHeader_Caption_Department)]
        [TestCase(PropertyHeader_Caption_Id)]
        [TestCase(PropertyHeader_Caption_Username)]
        [TestCase(PropertyHelptext_ConfigureResultGrid)]
        [TestCase(PropertyHelptext_ConfigureSearchCriteria)]
        [TestCase(PropertyLabel_ActualDate)]
        [TestCase(PropertyLabel_And)]
        [TestCase(PropertyLabel_Appointment)]
        [TestCase(PropertyLabel_BatchUpdateRecallDate)]
        [TestCase(PropertyLabel_Caching)]
        [TestCase(PropertyLabel_CampiagnTreeRootItem)]
        [TestCase(PropertyLabel_Cancel)]
        [TestCase(PropertyLabel_Caption)]
        [TestCase(PropertyLabel_ClientSummary)]
        [TestCase(PropertyLabel_CollapseButton)]
        [TestCase(PropertyLabel_Company)]
        [TestCase(PropertyLabel_Continue)]
        [TestCase(PropertyLabel_Custom)]
        [TestCase(PropertyLabel_DoMore)]
        [TestCase(PropertyLabel_Editable)]
        [TestCase(PropertyLabel_Email)]
        [TestCase(PropertyLabel_Empty)]
        [TestCase(PropertyLabel_ExpandButton)]
        [TestCase(PropertyLabel_FieldName)]
        [TestCase(PropertyLabel_fileLink)]
        [TestCase(PropertyLabel_Forecast)]
        [TestCase(PropertyLabel_FromDate)]
        [TestCase(PropertyLabel_IncidentSummary)]
        [TestCase(PropertyLabel_IncreaseQuota)]
        [TestCase(PropertyLabel_Individual)]
        [TestCase(PropertyLabel_Is)]
        [TestCase(PropertyLabel_IsBookMark)]
        [TestCase(PropertyLabel_IsDate)]
        [TestCase(PropertyLabel_IsHomePageQuery)]
        [TestCase(PropertyLabel_IsMobileBookMark)]
        [TestCase(PropertyLabel_Loading)]
        [TestCase(PropertyLabel_LoginOK)]
        [TestCase(PropertyLabel_MaxRows)]
        [TestCase(PropertyLabel_MessageTitle)]
        [TestCase(PropertyLabel_NewFolder)]
        [TestCase(PropertyLabel_No)]
        [TestCase(PropertyLabel_Ok)]
        [TestCase(PropertyLabel_Password)]
        [TestCase(PropertyLabel_PrivateFolder)]
        [TestCase(PropertyLabel_Product)]
        [TestCase(PropertyLabel_ProductTreeRootItem)]
        [TestCase(PropertyLabel_Profile)]
        [TestCase(PropertyLabel_Property)]
        [TestCase(PropertyLabel_PublicFolder)]
        [TestCase(PropertyLabel_Queryname)]
        [TestCase(PropertyLabel_RecallDate)]
        [TestCase(PropertyLabel_RecallDateDelete)]
        [TestCase(PropertyLabel_RecallDateUpdate)]
        [TestCase(PropertyLabel_RecallTime)]
        [TestCase(PropertyLabel_Required)]
        [TestCase(PropertyLabel_ResultAdminConsole)]
        [TestCase(PropertyLabel_SalesOpportunity)]
        [TestCase(PropertyLabel_SalesTask)]
        [TestCase(PropertyLabel_Save)]
        [TestCase(PropertyLabel_SaveAs)]
        [TestCase(PropertyLabel_SavedQueries)]
        [TestCase(PropertyLabel_Script)]
        [TestCase(PropertyLabel_ScriptTreeRootItem)]
        [TestCase(PropertyLabel_SearchAdminConsole)]
        [TestCase(PropertyLabel_SearchCriteria)]
        [TestCase(PropertyLabel_SearchFor)]
        [TestCase(PropertyLabel_SearchResults)]
        [TestCase(PropertyLabel_SearchType)]
        [TestCase(PropertyLabel_ServiceRequest)]
        [TestCase(PropertyLabel_ServiceTask)]
        [TestCase(PropertyLabel_SortBy)]
        [TestCase(PropertyLabel_SupportIncident)]
        [TestCase(PropertyLabel_SupportTask)]
        [TestCase(PropertyLabel_Task)]
        [TestCase(PropertyLabel_ThenBy)]
        [TestCase(PropertyLabel_ToDate)]
        [TestCase(PropertyLabel_UIResource)]
        [TestCase(PropertyLabel_UserID)]
        [TestCase(PropertyLabel_UserTreeRootItem)]
        [TestCase(PropertyLabel_WorkTicket)]
        [TestCase(PropertyLabel_Yes)]
        [TestCase(PropertyMessage_AccessControlListFailure)]
        [TestCase(PropertyMessage_AlreadyQueryDeleted)]
        [TestCase(PropertyMessage_ApplicationInitFail)]
        [TestCase(PropertyMessage_BatchUpdate)]
        [TestCase(PropertyMessage_BatchUpdateSaveFailure)]
        [TestCase(PropertyMessage_BatchUpdateTaskAlreadyExist)]
        [TestCase(PropertyMessage_CaptionBlankAlert)]
        [TestCase(PropertyMessage_DefaultListEmpty)]
        [TestCase(PropertyMessage_DeleteFolderConfirmation)]
        [TestCase(PropertyMessage_DeleteQueryConfirmation)]
        [TestCase(PropertyMessage_ElementNotFound)]
        [TestCase(PropertyMessage_EnterIntegerValue)]
        [TestCase(PropertyMessage_EnterQueryName)]
        [TestCase(PropertyMessage_EnterValueForMaxRows)]
        [TestCase(PropertyMessage_EntityNotFound)]
        [TestCase(PropertyMessage_ExceedMaxRecordLimitError)]
        [TestCase(PropertyMessage_ExceedMaxRecordLimitWarning)]
        [TestCase(PropertyMessage_FieldsMovedDisabledList)]
        [TestCase(PropertyMessage_Grouping)]
        [TestCase(PropertyMessage_HeaderListEmpty)]
        [TestCase(PropertyMessage_HowTouse)]
        [TestCase(PropertyMessage_IncorrectDataFormat)]
        [TestCase(PropertyMessage_InvalidPropertyName)]
        [TestCase(PropertyMessage_LoadingQuery)]
        [TestCase(PropertyMessage_MergeRecordAlert)]
        [TestCase(PropertyMessage_MergeRecordConfirmation)]
        [TestCase(PropertyMessage_MergeRecordSelect)]
        [TestCase(PropertyMessage_MergeRecordSuccess)]
        [TestCase(PropertyMessage_MobileBookMarkError)]
        [TestCase(PropertyMessage_MobileBookmarkValidationFailure)]
        [TestCase(PropertyMessage_ModelUnavailable)]
        [TestCase(PropertyMessage_ModulePrivilegeFailure)]
        [TestCase(PropertyMessage_MoreRecordWarning)]
        [TestCase(PropertyMessage_NoRecords)]
        [TestCase(PropertyMessage_NothingToSave)]
        [TestCase(PropertyMessage_NullElement)]
        [TestCase(PropertyMessage_NullFieldId)]
        [TestCase(PropertyMessage_NullFieldInfo)]
        [TestCase(PropertyMessage_NullFieldName)]
        [TestCase(PropertyMessage_NullMappings)]
        [TestCase(PropertyMessage_NullName)]
        [TestCase(PropertyMessage_NullNode)]
        [TestCase(PropertyMessage_NullUpdateXml)]
        [TestCase(PropertyMessage_NullValue)]
        [TestCase(PropertyMessage_ParentDropOnChild)]
        [TestCase(PropertyMessage_ProcessingSaveRequest)]
        [TestCase(PropertyMessage_PublicFolderDelete)]
        [TestCase(PropertyMessage_PublicQueryDelete)]
        [TestCase(PropertyMessage_PublicQueryOwner)]
        [TestCase(PropertyMessage_QueryAlreadyExists)]
        [TestCase(PropertyMessage_QueryDeleted)]
        [TestCase(PropertyMessage_QueryFolderMove)]
        [TestCase(PropertyMessage_QueryNotExist)]
        [TestCase(PropertyMessage_QuerySaved)]
        [TestCase(PropertyMessage_QuotaError)]
        [TestCase(PropertyMessage_QuotaSuccess)]
        [TestCase(PropertyMessage_ResetAlert)]
        [TestCase(PropertyMessage_ResetSave)]
        [TestCase(PropertyMessage_ResultGridAdminLoadFailure)]
        [TestCase(PropertyMessage_SaveAlert)]
        [TestCase(PropertyMessage_SaveConfirmation)]
        [TestCase(PropertyMessage_SaveFailure)]
        [TestCase(PropertyMessage_SaveQuerySelectFolder)]
        [TestCase(PropertyMessage_SaveSuccess)]
        [TestCase(PropertyMessage_SearchAdminLoadFailure)]
        [TestCase(PropertyMessage_SearchFilterLoadFail)]
        [TestCase(PropertyMessage_SelectEntity)]
        [TestCase(PropertyMessage_SelectFolder)]
        [TestCase(PropertyMessage_SelectFolderQueryToDelete)]
        [TestCase(PropertyMessage_SelectItemToEdit)]
        [TestCase(PropertyMessage_SortOrderSameValue)]
        [TestCase(PropertyMessage_SupplyCriteria)]
        [TestCase(PropertyMessage_TotalNoofRecords)]
        [TestCase(PropertyMessage_UnWatch)]
        [TestCase(PropertyMessage_UpdatePublicQuery)]
        [TestCase(PropertyMessage_UpdateQuery)]
        [TestCase(PropertyMessage_Watch)]
        [TestCase(PropertyTitle_Available)]
        [TestCase(PropertyTitle_BatchUpdate)]
        [TestCase(PropertyTitle_Detail)]
        [TestCase(PropertyTitle_Disabled)]
        [TestCase(PropertyTitle_EditField)]
        [TestCase(PropertyTitle_GridUserPicker_Description)]
        [TestCase(PropertyTitle_GridUserPicker_ID)]
        [TestCase(PropertyTitle_GridUserPicker_Name)]
        [TestCase(PropertyTitle_Header)]
        [TestCase(PropertyTitle_PleaseWait)]
        [TestCase(PropertyTitle_QueryExplorer)]
        [TestCase(PropertyTitle_SaveFilter)]
        [TestCase(PropertyTitle_Selected)]
        [TestCase(PropertyTitle_ServiceException)]
        [TestCase(PropertyTitle_UnabelResolve)]
        [TestCase(PropertyTitle_UserPicker)]
        [TestCase(PropertyToolTip_ActionMenu)]
        [TestCase(PropertyToolTip_ApplyChanges)]
        [TestCase(PropertyToolTip_BatchCancel)]
        [TestCase(PropertyToolTip_BatchSave)]
        [TestCase(PropertyToolTip_ClearCriteria)]
        [TestCase(PropertyToolTip_ConfigureMenu)]
        [TestCase(PropertyToolTip_ConfigureRLC)]
        [TestCase(PropertyToolTip_Copyright_Warning)]
        [TestCase(PropertyToolTip_CreateBookMark)]
        [TestCase(PropertyToolTip_CreateMobileBookMark)]
        [TestCase(PropertyToolTip_DeleteBookMark)]
        [TestCase(PropertyToolTip_DeleteFolderQuery)]
        [TestCase(PropertyToolTip_DeleteMobileBookMark)]
        [TestCase(PropertyToolTip_EditField)]
        [TestCase(PropertyToolTip_FullScreen)]
        [TestCase(PropertyToolTip_ListView)]
        [TestCase(PropertyToolTip_MergeItems)]
        [TestCase(PropertyToolTip_NewFolder)]
        [TestCase(PropertyToolTip_NormalView)]
        [TestCase(PropertyToolTip_OpenSavedQuery)]
        [TestCase(PropertyToolTip_RecordsSelected)]
        [TestCase(PropertyToolTip_RefreshResults)]
        [TestCase(PropertyToolTip_ResetDefault)]
        [TestCase(PropertyToolTip_Restore)]
        [TestCase(PropertyToolTip_ReturnSearch)]
        [TestCase(PropertyToolTip_RunQuery)]
        [TestCase(PropertyToolTip_Save)]
        [TestCase(PropertyToolTip_SaveFieldProperty)]
        [TestCase(PropertyToolTip_SaveQuery)]
        [TestCase(PropertyToolTip_SaveSetting)]
        [TestCase(PropertyToolTip_SelectFieldsQuery)]
        [TestCase(PropertyToolTip_SortAscending)]
        [TestCase(PropertyToolTip_SortDescending)]
        [TestCase(PropertyToolTip_TreeView)]
        [TestCase(PropertyTooltip_UnWatch)]
        [TestCase(PropertyToolTip_ViewSummary)]
        [TestCase(PropertyTooltip_Watch)]
        [TestCase(PropertyTooltip_WatchDisabled)]
        public void AUT_LocalResourceDesigner_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_Batch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_Batch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_Batch);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_Batch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_ConfigureResultGrid) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_ConfigureResultGrid_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_ConfigureResultGrid);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_ConfigureResultGrid);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_ConfigureSearchCriteria) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_ConfigureSearchCriteria_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_ConfigureSearchCriteria);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_ConfigureSearchCriteria);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_DefaultTab) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_DefaultTab_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_DefaultTab);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_DefaultTab);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_Export) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_Export_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_Export);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_Export);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_MB) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_MB_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_MB);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_MB);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_Merge) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_Merge_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_Merge);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_Merge);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_NewQuota) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_NewQuota_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_NewQuota);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_NewQuota);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_Print) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_Print_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_Print);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_Print);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_QuotaAllocated) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_QuotaAllocated_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_QuotaAllocated);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_QuotaAllocated);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_QuotaAvaiable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_QuotaAvaiable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_QuotaAvaiable);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_QuotaAvaiable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_QuotaNote) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_QuotaNote_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_QuotaNote);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_QuotaNote);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Caption_QuotaUsed) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Caption_QuotaUsed_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption_QuotaUsed);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption_QuotaUsed);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Culture) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Culture_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);
            Action currentAction = () => propertyInfo.SetValue(_localResourceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Culture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Culture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Data_EmailNoDisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Data_EmailNoDisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData_EmailNoDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyData_EmailNoDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Data_EmailYesDisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Data_EmailYesDisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData_EmailYesDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyData_EmailYesDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Data_EmptyDisplay) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Data_EmptyDisplay_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData_EmptyDisplay);
            var propertyInfo = this.GetPropertyInfo(PropertyData_EmptyDisplay);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Data_Female) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Data_Female_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData_Female);
            var propertyInfo = this.GetPropertyInfo(PropertyData_Female);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Data_Male) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Data_Male_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData_Male);
            var propertyInfo = this.GetPropertyInfo(PropertyData_Male);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Data_NotEmptyDisplay) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Data_NotEmptyDisplay_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData_NotEmptyDisplay);
            var propertyInfo = this.GetPropertyInfo(PropertyData_NotEmptyDisplay);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_BatchUpdateSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_BatchUpdateSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_BatchUpdateSave);
            var propertyInfo = this.GetPropertyInfo(PropertyError_BatchUpdateSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_ConnectionFail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_ConnectionFail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_ConnectionFail);
            var propertyInfo = this.GetPropertyInfo(PropertyError_ConnectionFail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_CSVFilter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_CSVFilter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_CSVFilter);
            var propertyInfo = this.GetPropertyInfo(PropertyError_CSVFilter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_ExportCSV) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_ExportCSV_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_ExportCSV);
            var propertyInfo = this.GetPropertyInfo(PropertyError_ExportCSV);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_InLineEdit) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_InLineEdit_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_InLineEdit);
            var propertyInfo = this.GetPropertyInfo(PropertyError_InLineEdit);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_InvalidLogin) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_InvalidLogin_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_InvalidLogin);
            var propertyInfo = this.GetPropertyInfo(PropertyError_InvalidLogin);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_MandatoryCriteria) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_MandatoryCriteria_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_MandatoryCriteria);
            var propertyInfo = this.GetPropertyInfo(PropertyError_MandatoryCriteria);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Error_SearchQueryLimit) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Error_SearchQueryLimit_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError_SearchQueryLimit);
            var propertyInfo = this.GetPropertyInfo(PropertyError_SearchQueryLimit);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Header_Caption_Department) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Header_Caption_Department_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeader_Caption_Department);
            var propertyInfo = this.GetPropertyInfo(PropertyHeader_Caption_Department);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Header_Caption_Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Header_Caption_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeader_Caption_Id);
            var propertyInfo = this.GetPropertyInfo(PropertyHeader_Caption_Id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Header_Caption_Username) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Header_Caption_Username_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeader_Caption_Username);
            var propertyInfo = this.GetPropertyInfo(PropertyHeader_Caption_Username);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Helptext_ConfigureResultGrid) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Helptext_ConfigureResultGrid_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHelptext_ConfigureResultGrid);
            var propertyInfo = this.GetPropertyInfo(PropertyHelptext_ConfigureResultGrid);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Helptext_ConfigureSearchCriteria) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Helptext_ConfigureSearchCriteria_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHelptext_ConfigureSearchCriteria);
            var propertyInfo = this.GetPropertyInfo(PropertyHelptext_ConfigureSearchCriteria);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ActualDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ActualDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ActualDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ActualDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_And) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_And_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_And);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_And);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Appointment) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Appointment_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Appointment);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Appointment);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_BatchUpdateRecallDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_BatchUpdateRecallDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_BatchUpdateRecallDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_BatchUpdateRecallDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Caching) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Caching_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Caching);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Caching);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_CampiagnTreeRootItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_CampiagnTreeRootItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_CampiagnTreeRootItem);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_CampiagnTreeRootItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Cancel) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Cancel_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Cancel);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Cancel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Caption) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Caption_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Caption);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Caption);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ClientSummary) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ClientSummary_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ClientSummary);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ClientSummary);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_CollapseButton) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_CollapseButton_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_CollapseButton);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_CollapseButton);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Company) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Company_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Company);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Company);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Continue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Continue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Continue);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Continue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Custom) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Custom_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Custom);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Custom);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_DoMore) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_DoMore_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_DoMore);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_DoMore);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Editable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Editable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Editable);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Editable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Email) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Email_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Email);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Email);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Empty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Empty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Empty);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Empty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ExpandButton) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ExpandButton_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ExpandButton);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ExpandButton);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_FieldName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_FieldName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_FieldName);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_FieldName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_fileLink) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_fileLink_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_fileLink);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_fileLink);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Forecast) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Forecast_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Forecast);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Forecast);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_FromDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_FromDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_FromDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_FromDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_IncidentSummary) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_IncidentSummary_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_IncidentSummary);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_IncidentSummary);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_IncreaseQuota) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_IncreaseQuota_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_IncreaseQuota);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_IncreaseQuota);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Individual) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Individual_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Individual);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Individual);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Is) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Is_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Is);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Is);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_IsBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_IsBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_IsBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_IsBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_IsDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_IsDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_IsDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_IsDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_IsHomePageQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_IsHomePageQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_IsHomePageQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_IsHomePageQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_IsMobileBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_IsMobileBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_IsMobileBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_IsMobileBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Loading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Loading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Loading);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Loading);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_LoginOK) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_LoginOK_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_LoginOK);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_LoginOK);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_MaxRows) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_MaxRows_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_MaxRows);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_MaxRows);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_MessageTitle) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_MessageTitle_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_MessageTitle);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_MessageTitle);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_NewFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_NewFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_NewFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_NewFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_No) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_No_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_No);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_No);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Ok) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Ok_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Ok);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Ok);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Password) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Password_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Password);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Password);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_PrivateFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_PrivateFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_PrivateFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_PrivateFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Product) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Product_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Product);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Product);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ProductTreeRootItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ProductTreeRootItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ProductTreeRootItem);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ProductTreeRootItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Profile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Profile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Profile);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Profile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Property) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Property_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Property);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Property);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_PublicFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_PublicFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_PublicFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_PublicFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Queryname) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Queryname_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Queryname);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Queryname);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_RecallDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_RecallDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_RecallDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_RecallDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_RecallDateDelete) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_RecallDateDelete_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_RecallDateDelete);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_RecallDateDelete);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_RecallDateUpdate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_RecallDateUpdate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_RecallDateUpdate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_RecallDateUpdate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_RecallTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_RecallTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_RecallTime);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_RecallTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Required) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Required_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Required);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Required);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ResultAdminConsole) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ResultAdminConsole_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ResultAdminConsole);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ResultAdminConsole);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SalesOpportunity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SalesOpportunity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SalesOpportunity);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SalesOpportunity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SalesTask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SalesTask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SalesTask);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SalesTask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Save) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Save_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Save);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Save);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SaveAs) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SaveAs_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SaveAs);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SaveAs);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SavedQueries) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SavedQueries_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SavedQueries);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SavedQueries);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Script) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Script_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Script);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Script);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ScriptTreeRootItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ScriptTreeRootItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ScriptTreeRootItem);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ScriptTreeRootItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SearchAdminConsole) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SearchAdminConsole_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SearchAdminConsole);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SearchAdminConsole);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SearchCriteria) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SearchCriteria_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SearchCriteria);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SearchCriteria);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SearchFor) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SearchFor_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SearchFor);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SearchFor);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SearchResults) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SearchResults_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SearchResults);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SearchResults);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SearchType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SearchType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SearchType);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SearchType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ServiceRequest) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ServiceRequest_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ServiceRequest);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ServiceRequest);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ServiceTask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ServiceTask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ServiceTask);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ServiceTask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SortBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SortBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SortBy);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SortBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SupportIncident) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SupportIncident_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SupportIncident);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SupportIncident);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_SupportTask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_SupportTask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_SupportTask);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_SupportTask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Task) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Task_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Task);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Task);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ThenBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ThenBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ThenBy);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ThenBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_ToDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_ToDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_ToDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_ToDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_UIResource) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_UIResource_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_UIResource);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_UIResource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_UserID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_UserID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_UserID);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_UserID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_UserTreeRootItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_UserTreeRootItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_UserTreeRootItem);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_UserTreeRootItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_WorkTicket) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_WorkTicket_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_WorkTicket);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_WorkTicket);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Label_Yes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Label_Yes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel_Yes);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel_Yes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_AccessControlListFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_AccessControlListFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_AccessControlListFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_AccessControlListFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_AlreadyQueryDeleted) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_AlreadyQueryDeleted_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_AlreadyQueryDeleted);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_AlreadyQueryDeleted);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ApplicationInitFail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ApplicationInitFail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ApplicationInitFail);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ApplicationInitFail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_BatchUpdate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_BatchUpdate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_BatchUpdate);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_BatchUpdate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_BatchUpdateSaveFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_BatchUpdateSaveFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_BatchUpdateSaveFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_BatchUpdateSaveFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_BatchUpdateTaskAlreadyExist) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_BatchUpdateTaskAlreadyExist_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_BatchUpdateTaskAlreadyExist);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_BatchUpdateTaskAlreadyExist);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_CaptionBlankAlert) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_CaptionBlankAlert_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_CaptionBlankAlert);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_CaptionBlankAlert);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_DefaultListEmpty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_DefaultListEmpty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_DefaultListEmpty);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_DefaultListEmpty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_DeleteFolderConfirmation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_DeleteFolderConfirmation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_DeleteFolderConfirmation);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_DeleteFolderConfirmation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_DeleteQueryConfirmation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_DeleteQueryConfirmation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_DeleteQueryConfirmation);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_DeleteQueryConfirmation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ElementNotFound) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ElementNotFound_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ElementNotFound);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ElementNotFound);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_EnterIntegerValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_EnterIntegerValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_EnterIntegerValue);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_EnterIntegerValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_EnterQueryName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_EnterQueryName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_EnterQueryName);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_EnterQueryName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_EnterValueForMaxRows) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_EnterValueForMaxRows_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_EnterValueForMaxRows);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_EnterValueForMaxRows);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_EntityNotFound) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_EntityNotFound_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_EntityNotFound);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_EntityNotFound);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ExceedMaxRecordLimitError) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ExceedMaxRecordLimitError_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ExceedMaxRecordLimitError);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ExceedMaxRecordLimitError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ExceedMaxRecordLimitWarning) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ExceedMaxRecordLimitWarning_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ExceedMaxRecordLimitWarning);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ExceedMaxRecordLimitWarning);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_FieldsMovedDisabledList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_FieldsMovedDisabledList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_FieldsMovedDisabledList);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_FieldsMovedDisabledList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_Grouping) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_Grouping_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_Grouping);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_Grouping);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_HeaderListEmpty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_HeaderListEmpty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_HeaderListEmpty);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_HeaderListEmpty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_HowTouse) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_HowTouse_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_HowTouse);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_HowTouse);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_IncorrectDataFormat) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_IncorrectDataFormat_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_IncorrectDataFormat);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_IncorrectDataFormat);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_InvalidPropertyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_InvalidPropertyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_InvalidPropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_InvalidPropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_LoadingQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_LoadingQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_LoadingQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_LoadingQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MergeRecordAlert) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MergeRecordAlert_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MergeRecordAlert);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MergeRecordAlert);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MergeRecordConfirmation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MergeRecordConfirmation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MergeRecordConfirmation);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MergeRecordConfirmation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MergeRecordSelect) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MergeRecordSelect_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MergeRecordSelect);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MergeRecordSelect);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MergeRecordSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MergeRecordSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MergeRecordSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MergeRecordSuccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MobileBookMarkError) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MobileBookMarkError_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MobileBookMarkError);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MobileBookMarkError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MobileBookmarkValidationFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MobileBookmarkValidationFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MobileBookmarkValidationFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MobileBookmarkValidationFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ModelUnavailable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ModelUnavailable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ModelUnavailable);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ModelUnavailable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ModulePrivilegeFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ModulePrivilegeFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ModulePrivilegeFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ModulePrivilegeFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_MoreRecordWarning) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_MoreRecordWarning_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_MoreRecordWarning);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_MoreRecordWarning);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NoRecords) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NoRecords_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NoRecords);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NoRecords);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NothingToSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NothingToSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NothingToSave);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NothingToSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullElement) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullElement_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullElement);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullElement);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullFieldId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullFieldId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullFieldId);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullFieldId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullFieldInfo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullFieldInfo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullFieldInfo);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullFieldInfo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullFieldName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullFieldName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullFieldName);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullFieldName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullMappings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullMappings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullMappings);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullMappings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullName);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullNode);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullUpdateXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullUpdateXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullUpdateXml);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullUpdateXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_NullValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_NullValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_NullValue);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_NullValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ParentDropOnChild) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ParentDropOnChild_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ParentDropOnChild);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ParentDropOnChild);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ProcessingSaveRequest) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ProcessingSaveRequest_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ProcessingSaveRequest);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ProcessingSaveRequest);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_PublicFolderDelete) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_PublicFolderDelete_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_PublicFolderDelete);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_PublicFolderDelete);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_PublicQueryDelete) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_PublicQueryDelete_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_PublicQueryDelete);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_PublicQueryDelete);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_PublicQueryOwner) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_PublicQueryOwner_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_PublicQueryOwner);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_PublicQueryOwner);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QueryAlreadyExists) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QueryAlreadyExists_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QueryAlreadyExists);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QueryAlreadyExists);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QueryDeleted) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QueryDeleted_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QueryDeleted);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QueryDeleted);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QueryFolderMove) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QueryFolderMove_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QueryFolderMove);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QueryFolderMove);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QueryNotExist) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QueryNotExist_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QueryNotExist);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QueryNotExist);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QuerySaved) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QuerySaved_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QuerySaved);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QuerySaved);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QuotaError) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QuotaError_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QuotaError);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QuotaError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_QuotaSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_QuotaSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_QuotaSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_QuotaSuccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ResetAlert) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ResetAlert_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ResetAlert);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ResetAlert);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ResetSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ResetSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ResetSave);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ResetSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_ResultGridAdminLoadFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_ResultGridAdminLoadFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_ResultGridAdminLoadFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_ResultGridAdminLoadFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SaveAlert) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SaveAlert_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SaveAlert);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SaveAlert);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SaveConfirmation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SaveConfirmation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SaveConfirmation);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SaveConfirmation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SaveFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SaveFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SaveFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SaveFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SaveQuerySelectFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SaveQuerySelectFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SaveQuerySelectFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SaveQuerySelectFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SaveSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SaveSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SaveSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SaveSuccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SearchAdminLoadFailure) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SearchAdminLoadFailure_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SearchAdminLoadFailure);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SearchAdminLoadFailure);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SearchFilterLoadFail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SearchFilterLoadFail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SearchFilterLoadFail);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SearchFilterLoadFail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SelectEntity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SelectEntity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SelectEntity);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SelectEntity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SelectFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SelectFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SelectFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SelectFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SelectFolderQueryToDelete) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SelectFolderQueryToDelete_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SelectFolderQueryToDelete);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SelectFolderQueryToDelete);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SelectItemToEdit) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SelectItemToEdit_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SelectItemToEdit);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SelectItemToEdit);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SortOrderSameValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SortOrderSameValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SortOrderSameValue);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SortOrderSameValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_SupplyCriteria) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_SupplyCriteria_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_SupplyCriteria);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_SupplyCriteria);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_TotalNoofRecords) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_TotalNoofRecords_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_TotalNoofRecords);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_TotalNoofRecords);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_UnWatch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_UnWatch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_UnWatch);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_UnWatch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_UpdatePublicQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_UpdatePublicQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_UpdatePublicQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_UpdatePublicQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_UpdateQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_UpdateQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_UpdateQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_UpdateQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Message_Watch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Message_Watch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage_Watch);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage_Watch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ResourceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_ResourceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);
            Action currentAction = () => propertyInfo.SetValue(_localResourceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ResourceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ResourceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_Available) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_Available_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_Available);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_Available);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_BatchUpdate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_BatchUpdate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_BatchUpdate);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_BatchUpdate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_Detail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_Detail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_Detail);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_Detail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_Disabled) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_Disabled_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_Disabled);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_Disabled);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_EditField) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_EditField_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_EditField);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_EditField);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_GridUserPicker_Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_GridUserPicker_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_GridUserPicker_Description);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_GridUserPicker_Description);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_GridUserPicker_ID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_GridUserPicker_ID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_GridUserPicker_ID);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_GridUserPicker_ID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_GridUserPicker_Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_GridUserPicker_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_GridUserPicker_Name);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_GridUserPicker_Name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_Header) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_Header_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_Header);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_Header);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_PleaseWait) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_PleaseWait_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_PleaseWait);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_PleaseWait);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_QueryExplorer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_QueryExplorer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_QueryExplorer);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_QueryExplorer);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_SaveFilter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_SaveFilter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_SaveFilter);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_SaveFilter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_Selected) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_Selected_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_Selected);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_Selected);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_ServiceException) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_ServiceException_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_ServiceException);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_ServiceException);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_UnabelResolve) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_UnabelResolve_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_UnabelResolve);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_UnabelResolve);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Title_UserPicker) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Title_UserPicker_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle_UserPicker);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle_UserPicker);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ActionMenu) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ActionMenu_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ActionMenu);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ActionMenu);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ApplyChanges) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ApplyChanges_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ApplyChanges);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ApplyChanges);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_BatchCancel) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_BatchCancel_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_BatchCancel);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_BatchCancel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_BatchSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_BatchSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_BatchSave);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_BatchSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ClearCriteria) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ClearCriteria_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ClearCriteria);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ClearCriteria);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ConfigureMenu) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ConfigureMenu_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ConfigureMenu);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ConfigureMenu);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ConfigureRLC) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ConfigureRLC_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ConfigureRLC);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ConfigureRLC);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_Copyright_Warning) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_Copyright_Warning_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_Copyright_Warning);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_Copyright_Warning);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_CreateBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_CreateBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_CreateBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_CreateBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_CreateMobileBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_CreateMobileBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_CreateMobileBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_CreateMobileBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_DeleteBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_DeleteBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_DeleteBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_DeleteBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_DeleteFolderQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_DeleteFolderQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_DeleteFolderQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_DeleteFolderQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_DeleteMobileBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_DeleteMobileBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_DeleteMobileBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_DeleteMobileBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_EditField) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_EditField_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_EditField);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_EditField);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_FullScreen) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_FullScreen_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_FullScreen);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_FullScreen);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ListView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ListView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ListView);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ListView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_MergeItems) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_MergeItems_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_MergeItems);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_MergeItems);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_NewFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_NewFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_NewFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_NewFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_NormalView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_NormalView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_NormalView);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_NormalView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_OpenSavedQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_OpenSavedQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_OpenSavedQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_OpenSavedQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_RecordsSelected) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_RecordsSelected_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_RecordsSelected);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_RecordsSelected);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_RefreshResults) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_RefreshResults_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_RefreshResults);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_RefreshResults);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ResetDefault) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ResetDefault_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ResetDefault);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ResetDefault);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_Restore) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_Restore_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_Restore);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_Restore);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ReturnSearch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ReturnSearch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ReturnSearch);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ReturnSearch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_RunQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_RunQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_RunQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_RunQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_Save) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_Save_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_Save);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_Save);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_SaveFieldProperty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_SaveFieldProperty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_SaveFieldProperty);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_SaveFieldProperty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_SaveQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_SaveQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_SaveQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_SaveQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_SaveSetting) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_SaveSetting_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_SaveSetting);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_SaveSetting);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_SelectFieldsQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_SelectFieldsQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_SelectFieldsQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_SelectFieldsQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_SortAscending) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_SortAscending_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_SortAscending);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_SortAscending);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_SortDescending) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_SortDescending_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_SortDescending);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_SortDescending);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_TreeView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_TreeView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_TreeView);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_TreeView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Tooltip_UnWatch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Tooltip_UnWatch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTooltip_UnWatch);
            var propertyInfo = this.GetPropertyInfo(PropertyTooltip_UnWatch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (ToolTip_ViewSummary) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_ToolTip_ViewSummary_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyToolTip_ViewSummary);
            var propertyInfo = this.GetPropertyInfo(PropertyToolTip_ViewSummary);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Tooltip_Watch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Tooltip_Watch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTooltip_Watch);
            var propertyInfo = this.GetPropertyInfo(PropertyTooltip_Watch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LocalResource) => Property (Tooltip_WatchDisabled) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LocalResourceDesigner_Public_Class_Tooltip_WatchDisabled_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTooltip_WatchDisabled);
            var propertyInfo = this.GetPropertyInfo(PropertyTooltip_WatchDisabled);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}