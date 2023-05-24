using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportingService2005" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReportingService2005Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService2005Test() : base(typeof(ReportingService2005))
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

        #region General Initializer : Class (ReportingService2005) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _reportingService2005InstanceType;
        private ReportingService2005 _reportingService2005Instance;
        private ReportingService2005 _reportingService2005InstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReportingService2005" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reportingService2005InstanceType = typeof(ReportingService2005);
            _reportingService2005InstanceFixture = this.Create<ReportingService2005>(false);
            _reportingService2005Instance = _reportingService2005InstanceFixture ?? this.Create<ReportingService2005>(true);
            CurrentInstance = _reportingService2005Instance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReportingService2005) Initializer

        #region Properties

        private const string PropertyServerInfoHeaderValue = "ServerInfoHeaderValue";
        private const string PropertyBatchHeaderValue = "BatchHeaderValue";
        private const string PropertyItemNamespaceHeaderValue = "ItemNamespaceHeaderValue";
        private const string PropertyUrl = "Url";
        private const string PropertyUseDefaultCredentials = "UseDefaultCredentials";

        #endregion

        #region Methods

        private const string MethodListSecureMethods = "ListSecureMethods";
        private const string MethodOnListSecureMethodsOperationCompleted = "OnListSecureMethodsOperationCompleted";
        private const string MethodCreateBatch = "CreateBatch";
        private const string MethodOnCreateBatchOperationCompleted = "OnCreateBatchOperationCompleted";
        private const string MethodCancelBatch = "CancelBatch";
        private const string MethodOnCancelBatchOperationCompleted = "OnCancelBatchOperationCompleted";
        private const string MethodExecuteBatch = "ExecuteBatch";
        private const string MethodOnExecuteBatchOperationCompleted = "OnExecuteBatchOperationCompleted";
        private const string MethodGetSystemProperties = "GetSystemProperties";
        private const string MethodOnGetSystemPropertiesOperationCompleted = "OnGetSystemPropertiesOperationCompleted";
        private const string MethodSetSystemProperties = "SetSystemProperties";
        private const string MethodOnSetSystemPropertiesOperationCompleted = "OnSetSystemPropertiesOperationCompleted";
        private const string MethodDeleteItem = "DeleteItem";
        private const string MethodOnDeleteItemOperationCompleted = "OnDeleteItemOperationCompleted";
        private const string MethodMoveItem = "MoveItem";
        private const string MethodOnMoveItemOperationCompleted = "OnMoveItemOperationCompleted";
        private const string MethodListChildren = "ListChildren";
        private const string MethodOnListChildrenOperationCompleted = "OnListChildrenOperationCompleted";
        private const string MethodListDependentItems = "ListDependentItems";
        private const string MethodOnListDependentItemsOperationCompleted = "OnListDependentItemsOperationCompleted";
        private const string MethodGetProperties = "GetProperties";
        private const string MethodOnGetPropertiesOperationCompleted = "OnGetPropertiesOperationCompleted";
        private const string MethodSetProperties = "SetProperties";
        private const string MethodOnSetPropertiesOperationCompleted = "OnSetPropertiesOperationCompleted";
        private const string MethodGetItemType = "GetItemType";
        private const string MethodOnGetItemTypeOperationCompleted = "OnGetItemTypeOperationCompleted";
        private const string MethodCreateFolder = "CreateFolder";
        private const string MethodOnCreateFolderOperationCompleted = "OnCreateFolderOperationCompleted";
        private const string MethodCreateReport = "CreateReport";
        private const string MethodOnCreateReportOperationCompleted = "OnCreateReportOperationCompleted";
        private const string MethodGetReportDefinition = "GetReportDefinition";
        private const string MethodOnGetReportDefinitionOperationCompleted = "OnGetReportDefinitionOperationCompleted";
        private const string MethodSetReportDefinition = "SetReportDefinition";
        private const string MethodOnSetReportDefinitionOperationCompleted = "OnSetReportDefinitionOperationCompleted";
        private const string MethodCreateResource = "CreateResource";
        private const string MethodOnCreateResourceOperationCompleted = "OnCreateResourceOperationCompleted";
        private const string MethodSetResourceContents = "SetResourceContents";
        private const string MethodOnSetResourceContentsOperationCompleted = "OnSetResourceContentsOperationCompleted";
        private const string MethodGetResourceContents = "GetResourceContents";
        private const string MethodOnGetResourceContentsOperationCompleted = "OnGetResourceContentsOperationCompleted";
        private const string MethodGetReportParameters = "GetReportParameters";
        private const string MethodOnGetReportParametersOperationCompleted = "OnGetReportParametersOperationCompleted";
        private const string MethodSetReportParameters = "SetReportParameters";
        private const string MethodOnSetReportParametersOperationCompleted = "OnSetReportParametersOperationCompleted";
        private const string MethodCreateLinkedReport = "CreateLinkedReport";
        private const string MethodOnCreateLinkedReportOperationCompleted = "OnCreateLinkedReportOperationCompleted";
        private const string MethodGetReportLink = "GetReportLink";
        private const string MethodOnGetReportLinkOperationCompleted = "OnGetReportLinkOperationCompleted";
        private const string MethodSetReportLink = "SetReportLink";
        private const string MethodOnSetReportLinkOperationCompleted = "OnSetReportLinkOperationCompleted";
        private const string MethodGetRenderResource = "GetRenderResource";
        private const string MethodOnGetRenderResourceOperationCompleted = "OnGetRenderResourceOperationCompleted";
        private const string MethodSetExecutionOptions = "SetExecutionOptions";
        private const string MethodOnSetExecutionOptionsOperationCompleted = "OnSetExecutionOptionsOperationCompleted";
        private const string MethodGetExecutionOptions = "GetExecutionOptions";
        private const string MethodOnGetExecutionOptionsOperationCompleted = "OnGetExecutionOptionsOperationCompleted";
        private const string MethodSetCacheOptions = "SetCacheOptions";
        private const string MethodOnSetCacheOptionsOperationCompleted = "OnSetCacheOptionsOperationCompleted";
        private const string MethodGetCacheOptions = "GetCacheOptions";
        private const string MethodOnGetCacheOptionsOperationCompleted = "OnGetCacheOptionsOperationCompleted";
        private const string MethodUpdateReportExecutionSnapshot = "UpdateReportExecutionSnapshot";
        private const string MethodOnUpdateReportExecutionSnapshotOperationCompleted = "OnUpdateReportExecutionSnapshotOperationCompleted";
        private const string MethodFlushCache = "FlushCache";
        private const string MethodOnFlushCacheOperationCompleted = "OnFlushCacheOperationCompleted";
        private const string MethodListJobs = "ListJobs";
        private const string MethodOnListJobsOperationCompleted = "OnListJobsOperationCompleted";
        private const string MethodCancelJob = "CancelJob";
        private const string MethodOnCancelJobOperationCompleted = "OnCancelJobOperationCompleted";
        private const string MethodCreateDataSource = "CreateDataSource";
        private const string MethodOnCreateDataSourceOperationCompleted = "OnCreateDataSourceOperationCompleted";
        private const string MethodGetDataSourceContents = "GetDataSourceContents";
        private const string MethodOnGetDataSourceContentsOperationCompleted = "OnGetDataSourceContentsOperationCompleted";
        private const string MethodSetDataSourceContents = "SetDataSourceContents";
        private const string MethodOnSetDataSourceContentsOperationCompleted = "OnSetDataSourceContentsOperationCompleted";
        private const string MethodEnableDataSource = "EnableDataSource";
        private const string MethodOnEnableDataSourceOperationCompleted = "OnEnableDataSourceOperationCompleted";
        private const string MethodDisableDataSource = "DisableDataSource";
        private const string MethodOnDisableDataSourceOperationCompleted = "OnDisableDataSourceOperationCompleted";
        private const string MethodSetItemDataSources = "SetItemDataSources";
        private const string MethodOnSetItemDataSourcesOperationCompleted = "OnSetItemDataSourcesOperationCompleted";
        private const string MethodGetItemDataSources = "GetItemDataSources";
        private const string MethodOnGetItemDataSourcesOperationCompleted = "OnGetItemDataSourcesOperationCompleted";
        private const string MethodGetItemDataSourcePrompts = "GetItemDataSourcePrompts";
        private const string MethodOnGetItemDataSourcePromptsOperationCompleted = "OnGetItemDataSourcePromptsOperationCompleted";
        private const string MethodCreateReportHistorySnapshot = "CreateReportHistorySnapshot";
        private const string MethodOnCreateReportHistorySnapshotOperationCompleted = "OnCreateReportHistorySnapshotOperationCompleted";
        private const string MethodSetReportHistoryOptions = "SetReportHistoryOptions";
        private const string MethodOnSetReportHistoryOptionsOperationCompleted = "OnSetReportHistoryOptionsOperationCompleted";
        private const string MethodGetReportHistoryOptions = "GetReportHistoryOptions";
        private const string MethodOnGetReportHistoryOptionsOperationCompleted = "OnGetReportHistoryOptionsOperationCompleted";
        private const string MethodSetReportHistoryLimit = "SetReportHistoryLimit";
        private const string MethodOnSetReportHistoryLimitOperationCompleted = "OnSetReportHistoryLimitOperationCompleted";
        private const string MethodGetReportHistoryLimit = "GetReportHistoryLimit";
        private const string MethodOnGetReportHistoryLimitOperationCompleted = "OnGetReportHistoryLimitOperationCompleted";
        private const string MethodListReportHistory = "ListReportHistory";
        private const string MethodOnListReportHistoryOperationCompleted = "OnListReportHistoryOperationCompleted";
        private const string MethodDeleteReportHistorySnapshot = "DeleteReportHistorySnapshot";
        private const string MethodOnDeleteReportHistorySnapshotOperationCompleted = "OnDeleteReportHistorySnapshotOperationCompleted";
        private const string MethodFindItems = "FindItems";
        private const string MethodOnFindItemsOperationCompleted = "OnFindItemsOperationCompleted";
        private const string MethodCreateSchedule = "CreateSchedule";
        private const string MethodOnCreateScheduleOperationCompleted = "OnCreateScheduleOperationCompleted";
        private const string MethodDeleteSchedule = "DeleteSchedule";
        private const string MethodOnDeleteScheduleOperationCompleted = "OnDeleteScheduleOperationCompleted";
        private const string MethodSetScheduleProperties = "SetScheduleProperties";
        private const string MethodOnSetSchedulePropertiesOperationCompleted = "OnSetSchedulePropertiesOperationCompleted";
        private const string MethodGetScheduleProperties = "GetScheduleProperties";
        private const string MethodOnGetSchedulePropertiesOperationCompleted = "OnGetSchedulePropertiesOperationCompleted";
        private const string MethodListScheduledReports = "ListScheduledReports";
        private const string MethodOnListScheduledReportsOperationCompleted = "OnListScheduledReportsOperationCompleted";
        private const string MethodListSchedules = "ListSchedules";
        private const string MethodOnListSchedulesOperationCompleted = "OnListSchedulesOperationCompleted";
        private const string MethodPauseSchedule = "PauseSchedule";
        private const string MethodOnPauseScheduleOperationCompleted = "OnPauseScheduleOperationCompleted";
        private const string MethodResumeSchedule = "ResumeSchedule";
        private const string MethodOnResumeScheduleOperationCompleted = "OnResumeScheduleOperationCompleted";
        private const string MethodCreateSubscription = "CreateSubscription";
        private const string MethodOnCreateSubscriptionOperationCompleted = "OnCreateSubscriptionOperationCompleted";
        private const string MethodCreateDataDrivenSubscription = "CreateDataDrivenSubscription";
        private const string MethodOnCreateDataDrivenSubscriptionOperationCompleted = "OnCreateDataDrivenSubscriptionOperationCompleted";
        private const string MethodSetSubscriptionProperties = "SetSubscriptionProperties";
        private const string MethodOnSetSubscriptionPropertiesOperationCompleted = "OnSetSubscriptionPropertiesOperationCompleted";
        private const string MethodSetDataDrivenSubscriptionProperties = "SetDataDrivenSubscriptionProperties";
        private const string MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted = "OnSetDataDrivenSubscriptionPropertiesOperationCompleted";
        private const string MethodGetSubscriptionProperties = "GetSubscriptionProperties";
        private const string MethodOnGetSubscriptionPropertiesOperationCompleted = "OnGetSubscriptionPropertiesOperationCompleted";
        private const string MethodGetDataDrivenSubscriptionProperties = "GetDataDrivenSubscriptionProperties";
        private const string MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted = "OnGetDataDrivenSubscriptionPropertiesOperationCompleted";
        private const string MethodDeleteSubscription = "DeleteSubscription";
        private const string MethodOnDeleteSubscriptionOperationCompleted = "OnDeleteSubscriptionOperationCompleted";
        private const string MethodPrepareQuery = "PrepareQuery";
        private const string MethodOnPrepareQueryOperationCompleted = "OnPrepareQueryOperationCompleted";
        private const string MethodGetExtensionSettings = "GetExtensionSettings";
        private const string MethodOnGetExtensionSettingsOperationCompleted = "OnGetExtensionSettingsOperationCompleted";
        private const string MethodValidateExtensionSettings = "ValidateExtensionSettings";
        private const string MethodOnValidateExtensionSettingsOperationCompleted = "OnValidateExtensionSettingsOperationCompleted";
        private const string MethodListSubscriptions = "ListSubscriptions";
        private const string MethodOnListSubscriptionsOperationCompleted = "OnListSubscriptionsOperationCompleted";
        private const string MethodListSubscriptionsUsingDataSource = "ListSubscriptionsUsingDataSource";
        private const string MethodOnListSubscriptionsUsingDataSourceOperationCompleted = "OnListSubscriptionsUsingDataSourceOperationCompleted";
        private const string MethodListExtensions = "ListExtensions";
        private const string MethodOnListExtensionsOperationCompleted = "OnListExtensionsOperationCompleted";
        private const string MethodListEvents = "ListEvents";
        private const string MethodOnListEventsOperationCompleted = "OnListEventsOperationCompleted";
        private const string MethodFireEvent = "FireEvent";
        private const string MethodOnFireEventOperationCompleted = "OnFireEventOperationCompleted";
        private const string MethodListTasks = "ListTasks";
        private const string MethodOnListTasksOperationCompleted = "OnListTasksOperationCompleted";
        private const string MethodListRoles = "ListRoles";
        private const string MethodOnListRolesOperationCompleted = "OnListRolesOperationCompleted";
        private const string MethodCreateRole = "CreateRole";
        private const string MethodOnCreateRoleOperationCompleted = "OnCreateRoleOperationCompleted";
        private const string MethodDeleteRole = "DeleteRole";
        private const string MethodOnDeleteRoleOperationCompleted = "OnDeleteRoleOperationCompleted";
        private const string MethodGetRoleProperties = "GetRoleProperties";
        private const string MethodOnGetRolePropertiesOperationCompleted = "OnGetRolePropertiesOperationCompleted";
        private const string MethodSetRoleProperties = "SetRoleProperties";
        private const string MethodOnSetRolePropertiesOperationCompleted = "OnSetRolePropertiesOperationCompleted";
        private const string MethodGetSystemPolicies = "GetSystemPolicies";
        private const string MethodOnGetSystemPoliciesOperationCompleted = "OnGetSystemPoliciesOperationCompleted";
        private const string MethodSetSystemPolicies = "SetSystemPolicies";
        private const string MethodOnSetSystemPoliciesOperationCompleted = "OnSetSystemPoliciesOperationCompleted";
        private const string MethodGetPolicies = "GetPolicies";
        private const string MethodOnGetPoliciesOperationCompleted = "OnGetPoliciesOperationCompleted";
        private const string MethodSetPolicies = "SetPolicies";
        private const string MethodOnSetPoliciesOperationCompleted = "OnSetPoliciesOperationCompleted";
        private const string MethodInheritParentSecurity = "InheritParentSecurity";
        private const string MethodOnInheritParentSecurityOperationCompleted = "OnInheritParentSecurityOperationCompleted";
        private const string MethodGetSystemPermissions = "GetSystemPermissions";
        private const string MethodOnGetSystemPermissionsOperationCompleted = "OnGetSystemPermissionsOperationCompleted";
        private const string MethodGetPermissions = "GetPermissions";
        private const string MethodOnGetPermissionsOperationCompleted = "OnGetPermissionsOperationCompleted";
        private const string MethodLogonUser = "LogonUser";
        private const string MethodOnLogonUserOperationCompleted = "OnLogonUserOperationCompleted";
        private const string MethodLogoff = "Logoff";
        private const string MethodOnLogoffOperationCompleted = "OnLogoffOperationCompleted";
        private const string MethodCreateModel = "CreateModel";
        private const string MethodOnCreateModelOperationCompleted = "OnCreateModelOperationCompleted";
        private const string MethodGetModelDefinition = "GetModelDefinition";
        private const string MethodOnGetModelDefinitionOperationCompleted = "OnGetModelDefinitionOperationCompleted";
        private const string MethodSetModelDefinition = "SetModelDefinition";
        private const string MethodOnSetModelDefinitionOperationCompleted = "OnSetModelDefinitionOperationCompleted";
        private const string MethodListModelPerspectives = "ListModelPerspectives";
        private const string MethodOnListModelPerspectivesOperationCompleted = "OnListModelPerspectivesOperationCompleted";
        private const string MethodGetUserModel = "GetUserModel";
        private const string MethodOnGetUserModelOperationCompleted = "OnGetUserModelOperationCompleted";
        private const string MethodListModelItemChildren = "ListModelItemChildren";
        private const string MethodOnListModelItemChildrenOperationCompleted = "OnListModelItemChildrenOperationCompleted";
        private const string MethodGetModelItemPermissions = "GetModelItemPermissions";
        private const string MethodOnGetModelItemPermissionsOperationCompleted = "OnGetModelItemPermissionsOperationCompleted";
        private const string MethodGetModelItemPolicies = "GetModelItemPolicies";
        private const string MethodOnGetModelItemPoliciesOperationCompleted = "OnGetModelItemPoliciesOperationCompleted";
        private const string MethodSetModelItemPolicies = "SetModelItemPolicies";
        private const string MethodOnSetModelItemPoliciesOperationCompleted = "OnSetModelItemPoliciesOperationCompleted";
        private const string MethodInheritModelItemParentSecurity = "InheritModelItemParentSecurity";
        private const string MethodOnInheritModelItemParentSecurityOperationCompleted = "OnInheritModelItemParentSecurityOperationCompleted";
        private const string MethodRemoveAllModelItemPolicies = "RemoveAllModelItemPolicies";
        private const string MethodOnRemoveAllModelItemPoliciesOperationCompleted = "OnRemoveAllModelItemPoliciesOperationCompleted";
        private const string MethodSetModelDrillthroughReports = "SetModelDrillthroughReports";
        private const string MethodOnSetModelDrillthroughReportsOperationCompleted = "OnSetModelDrillthroughReportsOperationCompleted";
        private const string MethodListModelDrillthroughReports = "ListModelDrillthroughReports";
        private const string MethodOnListModelDrillthroughReportsOperationCompleted = "OnListModelDrillthroughReportsOperationCompleted";
        private const string MethodGenerateModel = "GenerateModel";
        private const string MethodOnGenerateModelOperationCompleted = "OnGenerateModelOperationCompleted";
        private const string MethodRegenerateModel = "RegenerateModel";
        private const string MethodOnRegenerateModelOperationCompleted = "OnRegenerateModelOperationCompleted";
        private const string MethodIsLocalFileSystemWebService = "IsLocalFileSystemWebService";

        #endregion

        #region Fields

        private const string FieldserverInfoHeaderValueField = "serverInfoHeaderValueField";
        private const string FieldListSecureMethodsOperationCompleted = "ListSecureMethodsOperationCompleted";
        private const string FieldCreateBatchOperationCompleted = "CreateBatchOperationCompleted";
        private const string FieldbatchHeaderValueField = "batchHeaderValueField";
        private const string FieldCancelBatchOperationCompleted = "CancelBatchOperationCompleted";
        private const string FieldExecuteBatchOperationCompleted = "ExecuteBatchOperationCompleted";
        private const string FieldGetSystemPropertiesOperationCompleted = "GetSystemPropertiesOperationCompleted";
        private const string FieldSetSystemPropertiesOperationCompleted = "SetSystemPropertiesOperationCompleted";
        private const string FieldDeleteItemOperationCompleted = "DeleteItemOperationCompleted";
        private const string FieldMoveItemOperationCompleted = "MoveItemOperationCompleted";
        private const string FieldListChildrenOperationCompleted = "ListChildrenOperationCompleted";
        private const string FieldListDependentItemsOperationCompleted = "ListDependentItemsOperationCompleted";
        private const string FielditemNamespaceHeaderValueField = "itemNamespaceHeaderValueField";
        private const string FieldGetPropertiesOperationCompleted = "GetPropertiesOperationCompleted";
        private const string FieldSetPropertiesOperationCompleted = "SetPropertiesOperationCompleted";
        private const string FieldGetItemTypeOperationCompleted = "GetItemTypeOperationCompleted";
        private const string FieldCreateFolderOperationCompleted = "CreateFolderOperationCompleted";
        private const string FieldCreateReportOperationCompleted = "CreateReportOperationCompleted";
        private const string FieldGetReportDefinitionOperationCompleted = "GetReportDefinitionOperationCompleted";
        private const string FieldSetReportDefinitionOperationCompleted = "SetReportDefinitionOperationCompleted";
        private const string FieldCreateResourceOperationCompleted = "CreateResourceOperationCompleted";
        private const string FieldSetResourceContentsOperationCompleted = "SetResourceContentsOperationCompleted";
        private const string FieldGetResourceContentsOperationCompleted = "GetResourceContentsOperationCompleted";
        private const string FieldGetReportParametersOperationCompleted = "GetReportParametersOperationCompleted";
        private const string FieldSetReportParametersOperationCompleted = "SetReportParametersOperationCompleted";
        private const string FieldCreateLinkedReportOperationCompleted = "CreateLinkedReportOperationCompleted";
        private const string FieldGetReportLinkOperationCompleted = "GetReportLinkOperationCompleted";
        private const string FieldSetReportLinkOperationCompleted = "SetReportLinkOperationCompleted";
        private const string FieldGetRenderResourceOperationCompleted = "GetRenderResourceOperationCompleted";
        private const string FieldSetExecutionOptionsOperationCompleted = "SetExecutionOptionsOperationCompleted";
        private const string FieldGetExecutionOptionsOperationCompleted = "GetExecutionOptionsOperationCompleted";
        private const string FieldSetCacheOptionsOperationCompleted = "SetCacheOptionsOperationCompleted";
        private const string FieldGetCacheOptionsOperationCompleted = "GetCacheOptionsOperationCompleted";
        private const string FieldUpdateReportExecutionSnapshotOperationCompleted = "UpdateReportExecutionSnapshotOperationCompleted";
        private const string FieldFlushCacheOperationCompleted = "FlushCacheOperationCompleted";
        private const string FieldListJobsOperationCompleted = "ListJobsOperationCompleted";
        private const string FieldCancelJobOperationCompleted = "CancelJobOperationCompleted";
        private const string FieldCreateDataSourceOperationCompleted = "CreateDataSourceOperationCompleted";
        private const string FieldGetDataSourceContentsOperationCompleted = "GetDataSourceContentsOperationCompleted";
        private const string FieldSetDataSourceContentsOperationCompleted = "SetDataSourceContentsOperationCompleted";
        private const string FieldEnableDataSourceOperationCompleted = "EnableDataSourceOperationCompleted";
        private const string FieldDisableDataSourceOperationCompleted = "DisableDataSourceOperationCompleted";
        private const string FieldSetItemDataSourcesOperationCompleted = "SetItemDataSourcesOperationCompleted";
        private const string FieldGetItemDataSourcesOperationCompleted = "GetItemDataSourcesOperationCompleted";
        private const string FieldGetItemDataSourcePromptsOperationCompleted = "GetItemDataSourcePromptsOperationCompleted";
        private const string FieldCreateReportHistorySnapshotOperationCompleted = "CreateReportHistorySnapshotOperationCompleted";
        private const string FieldSetReportHistoryOptionsOperationCompleted = "SetReportHistoryOptionsOperationCompleted";
        private const string FieldGetReportHistoryOptionsOperationCompleted = "GetReportHistoryOptionsOperationCompleted";
        private const string FieldSetReportHistoryLimitOperationCompleted = "SetReportHistoryLimitOperationCompleted";
        private const string FieldGetReportHistoryLimitOperationCompleted = "GetReportHistoryLimitOperationCompleted";
        private const string FieldListReportHistoryOperationCompleted = "ListReportHistoryOperationCompleted";
        private const string FieldDeleteReportHistorySnapshotOperationCompleted = "DeleteReportHistorySnapshotOperationCompleted";
        private const string FieldFindItemsOperationCompleted = "FindItemsOperationCompleted";
        private const string FieldCreateScheduleOperationCompleted = "CreateScheduleOperationCompleted";
        private const string FieldDeleteScheduleOperationCompleted = "DeleteScheduleOperationCompleted";
        private const string FieldSetSchedulePropertiesOperationCompleted = "SetSchedulePropertiesOperationCompleted";
        private const string FieldGetSchedulePropertiesOperationCompleted = "GetSchedulePropertiesOperationCompleted";
        private const string FieldListScheduledReportsOperationCompleted = "ListScheduledReportsOperationCompleted";
        private const string FieldListSchedulesOperationCompleted = "ListSchedulesOperationCompleted";
        private const string FieldPauseScheduleOperationCompleted = "PauseScheduleOperationCompleted";
        private const string FieldResumeScheduleOperationCompleted = "ResumeScheduleOperationCompleted";
        private const string FieldCreateSubscriptionOperationCompleted = "CreateSubscriptionOperationCompleted";
        private const string FieldCreateDataDrivenSubscriptionOperationCompleted = "CreateDataDrivenSubscriptionOperationCompleted";
        private const string FieldSetSubscriptionPropertiesOperationCompleted = "SetSubscriptionPropertiesOperationCompleted";
        private const string FieldSetDataDrivenSubscriptionPropertiesOperationCompleted = "SetDataDrivenSubscriptionPropertiesOperationCompleted";
        private const string FieldGetSubscriptionPropertiesOperationCompleted = "GetSubscriptionPropertiesOperationCompleted";
        private const string FieldGetDataDrivenSubscriptionPropertiesOperationCompleted = "GetDataDrivenSubscriptionPropertiesOperationCompleted";
        private const string FieldDeleteSubscriptionOperationCompleted = "DeleteSubscriptionOperationCompleted";
        private const string FieldPrepareQueryOperationCompleted = "PrepareQueryOperationCompleted";
        private const string FieldGetExtensionSettingsOperationCompleted = "GetExtensionSettingsOperationCompleted";
        private const string FieldValidateExtensionSettingsOperationCompleted = "ValidateExtensionSettingsOperationCompleted";
        private const string FieldListSubscriptionsOperationCompleted = "ListSubscriptionsOperationCompleted";
        private const string FieldListSubscriptionsUsingDataSourceOperationCompleted = "ListSubscriptionsUsingDataSourceOperationCompleted";
        private const string FieldListExtensionsOperationCompleted = "ListExtensionsOperationCompleted";
        private const string FieldListEventsOperationCompleted = "ListEventsOperationCompleted";
        private const string FieldFireEventOperationCompleted = "FireEventOperationCompleted";
        private const string FieldListTasksOperationCompleted = "ListTasksOperationCompleted";
        private const string FieldListRolesOperationCompleted = "ListRolesOperationCompleted";
        private const string FieldCreateRoleOperationCompleted = "CreateRoleOperationCompleted";
        private const string FieldDeleteRoleOperationCompleted = "DeleteRoleOperationCompleted";
        private const string FieldGetRolePropertiesOperationCompleted = "GetRolePropertiesOperationCompleted";
        private const string FieldSetRolePropertiesOperationCompleted = "SetRolePropertiesOperationCompleted";
        private const string FieldGetSystemPoliciesOperationCompleted = "GetSystemPoliciesOperationCompleted";
        private const string FieldSetSystemPoliciesOperationCompleted = "SetSystemPoliciesOperationCompleted";
        private const string FieldGetPoliciesOperationCompleted = "GetPoliciesOperationCompleted";
        private const string FieldSetPoliciesOperationCompleted = "SetPoliciesOperationCompleted";
        private const string FieldInheritParentSecurityOperationCompleted = "InheritParentSecurityOperationCompleted";
        private const string FieldGetSystemPermissionsOperationCompleted = "GetSystemPermissionsOperationCompleted";
        private const string FieldGetPermissionsOperationCompleted = "GetPermissionsOperationCompleted";
        private const string FieldLogonUserOperationCompleted = "LogonUserOperationCompleted";
        private const string FieldLogoffOperationCompleted = "LogoffOperationCompleted";
        private const string FieldCreateModelOperationCompleted = "CreateModelOperationCompleted";
        private const string FieldGetModelDefinitionOperationCompleted = "GetModelDefinitionOperationCompleted";
        private const string FieldSetModelDefinitionOperationCompleted = "SetModelDefinitionOperationCompleted";
        private const string FieldListModelPerspectivesOperationCompleted = "ListModelPerspectivesOperationCompleted";
        private const string FieldGetUserModelOperationCompleted = "GetUserModelOperationCompleted";
        private const string FieldListModelItemChildrenOperationCompleted = "ListModelItemChildrenOperationCompleted";
        private const string FieldGetModelItemPermissionsOperationCompleted = "GetModelItemPermissionsOperationCompleted";
        private const string FieldGetModelItemPoliciesOperationCompleted = "GetModelItemPoliciesOperationCompleted";
        private const string FieldSetModelItemPoliciesOperationCompleted = "SetModelItemPoliciesOperationCompleted";
        private const string FieldInheritModelItemParentSecurityOperationCompleted = "InheritModelItemParentSecurityOperationCompleted";
        private const string FieldRemoveAllModelItemPoliciesOperationCompleted = "RemoveAllModelItemPoliciesOperationCompleted";
        private const string FieldSetModelDrillthroughReportsOperationCompleted = "SetModelDrillthroughReportsOperationCompleted";
        private const string FieldListModelDrillthroughReportsOperationCompleted = "ListModelDrillthroughReportsOperationCompleted";
        private const string FieldGenerateModelOperationCompleted = "GenerateModelOperationCompleted";
        private const string FieldRegenerateModelOperationCompleted = "RegenerateModelOperationCompleted";
        private const string FielduseDefaultCredentialsSetExplicitly = "useDefaultCredentialsSetExplicitly";

        #endregion

        #endregion

        #region General Initializer : Class (ReportingService2005) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportingService2005_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReportingService2005) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportingService2005_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReportingService2005) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportingService2005_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReportingService2005)

        #region General Initializer : Class (ReportingService2005) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodListSecureMethods, 0)]
        [TestCase(MethodOnListSecureMethodsOperationCompleted, 0)]
        [TestCase(MethodCreateBatch, 0)]
        [TestCase(MethodOnCreateBatchOperationCompleted, 0)]
        [TestCase(MethodCancelBatch, 0)]
        [TestCase(MethodOnCancelBatchOperationCompleted, 0)]
        [TestCase(MethodExecuteBatch, 0)]
        [TestCase(MethodOnExecuteBatchOperationCompleted, 0)]
        [TestCase(MethodGetSystemProperties, 0)]
        [TestCase(MethodOnGetSystemPropertiesOperationCompleted, 0)]
        [TestCase(MethodSetSystemProperties, 0)]
        [TestCase(MethodOnSetSystemPropertiesOperationCompleted, 0)]
        [TestCase(MethodDeleteItem, 0)]
        [TestCase(MethodOnDeleteItemOperationCompleted, 0)]
        [TestCase(MethodMoveItem, 0)]
        [TestCase(MethodOnMoveItemOperationCompleted, 0)]
        [TestCase(MethodListChildren, 0)]
        [TestCase(MethodOnListChildrenOperationCompleted, 0)]
        [TestCase(MethodListDependentItems, 0)]
        [TestCase(MethodOnListDependentItemsOperationCompleted, 0)]
        [TestCase(MethodGetProperties, 0)]
        [TestCase(MethodOnGetPropertiesOperationCompleted, 0)]
        [TestCase(MethodSetProperties, 0)]
        [TestCase(MethodOnSetPropertiesOperationCompleted, 0)]
        [TestCase(MethodGetItemType, 0)]
        [TestCase(MethodOnGetItemTypeOperationCompleted, 0)]
        [TestCase(MethodCreateFolder, 0)]
        [TestCase(MethodOnCreateFolderOperationCompleted, 0)]
        [TestCase(MethodCreateReport, 0)]
        [TestCase(MethodOnCreateReportOperationCompleted, 0)]
        [TestCase(MethodGetReportDefinition, 0)]
        [TestCase(MethodOnGetReportDefinitionOperationCompleted, 0)]
        [TestCase(MethodSetReportDefinition, 0)]
        [TestCase(MethodOnSetReportDefinitionOperationCompleted, 0)]
        [TestCase(MethodCreateResource, 0)]
        [TestCase(MethodOnCreateResourceOperationCompleted, 0)]
        [TestCase(MethodSetResourceContents, 0)]
        [TestCase(MethodOnSetResourceContentsOperationCompleted, 0)]
        [TestCase(MethodGetResourceContents, 0)]
        [TestCase(MethodOnGetResourceContentsOperationCompleted, 0)]
        [TestCase(MethodGetReportParameters, 0)]
        [TestCase(MethodOnGetReportParametersOperationCompleted, 0)]
        [TestCase(MethodSetReportParameters, 0)]
        [TestCase(MethodOnSetReportParametersOperationCompleted, 0)]
        [TestCase(MethodCreateLinkedReport, 0)]
        [TestCase(MethodOnCreateLinkedReportOperationCompleted, 0)]
        [TestCase(MethodGetReportLink, 0)]
        [TestCase(MethodOnGetReportLinkOperationCompleted, 0)]
        [TestCase(MethodSetReportLink, 0)]
        [TestCase(MethodOnSetReportLinkOperationCompleted, 0)]
        [TestCase(MethodGetRenderResource, 0)]
        [TestCase(MethodOnGetRenderResourceOperationCompleted, 0)]
        [TestCase(MethodSetExecutionOptions, 0)]
        [TestCase(MethodOnSetExecutionOptionsOperationCompleted, 0)]
        [TestCase(MethodGetExecutionOptions, 0)]
        [TestCase(MethodOnGetExecutionOptionsOperationCompleted, 0)]
        [TestCase(MethodSetCacheOptions, 0)]
        [TestCase(MethodOnSetCacheOptionsOperationCompleted, 0)]
        [TestCase(MethodGetCacheOptions, 0)]
        [TestCase(MethodOnGetCacheOptionsOperationCompleted, 0)]
        [TestCase(MethodUpdateReportExecutionSnapshot, 0)]
        [TestCase(MethodOnUpdateReportExecutionSnapshotOperationCompleted, 0)]
        [TestCase(MethodFlushCache, 0)]
        [TestCase(MethodOnFlushCacheOperationCompleted, 0)]
        [TestCase(MethodListJobs, 0)]
        [TestCase(MethodOnListJobsOperationCompleted, 0)]
        [TestCase(MethodCancelJob, 0)]
        [TestCase(MethodOnCancelJobOperationCompleted, 0)]
        [TestCase(MethodCreateDataSource, 0)]
        [TestCase(MethodOnCreateDataSourceOperationCompleted, 0)]
        [TestCase(MethodGetDataSourceContents, 0)]
        [TestCase(MethodOnGetDataSourceContentsOperationCompleted, 0)]
        [TestCase(MethodSetDataSourceContents, 0)]
        [TestCase(MethodOnSetDataSourceContentsOperationCompleted, 0)]
        [TestCase(MethodEnableDataSource, 0)]
        [TestCase(MethodOnEnableDataSourceOperationCompleted, 0)]
        [TestCase(MethodDisableDataSource, 0)]
        [TestCase(MethodOnDisableDataSourceOperationCompleted, 0)]
        [TestCase(MethodSetItemDataSources, 0)]
        [TestCase(MethodOnSetItemDataSourcesOperationCompleted, 0)]
        [TestCase(MethodGetItemDataSources, 0)]
        [TestCase(MethodOnGetItemDataSourcesOperationCompleted, 0)]
        [TestCase(MethodGetItemDataSourcePrompts, 0)]
        [TestCase(MethodOnGetItemDataSourcePromptsOperationCompleted, 0)]
        [TestCase(MethodCreateReportHistorySnapshot, 0)]
        [TestCase(MethodOnCreateReportHistorySnapshotOperationCompleted, 0)]
        [TestCase(MethodSetReportHistoryOptions, 0)]
        [TestCase(MethodOnSetReportHistoryOptionsOperationCompleted, 0)]
        [TestCase(MethodGetReportHistoryOptions, 0)]
        [TestCase(MethodOnGetReportHistoryOptionsOperationCompleted, 0)]
        [TestCase(MethodSetReportHistoryLimit, 0)]
        [TestCase(MethodOnSetReportHistoryLimitOperationCompleted, 0)]
        [TestCase(MethodGetReportHistoryLimit, 0)]
        [TestCase(MethodOnGetReportHistoryLimitOperationCompleted, 0)]
        [TestCase(MethodListReportHistory, 0)]
        [TestCase(MethodOnListReportHistoryOperationCompleted, 0)]
        [TestCase(MethodDeleteReportHistorySnapshot, 0)]
        [TestCase(MethodOnDeleteReportHistorySnapshotOperationCompleted, 0)]
        [TestCase(MethodFindItems, 0)]
        [TestCase(MethodOnFindItemsOperationCompleted, 0)]
        [TestCase(MethodCreateSchedule, 0)]
        [TestCase(MethodOnCreateScheduleOperationCompleted, 0)]
        [TestCase(MethodDeleteSchedule, 0)]
        [TestCase(MethodOnDeleteScheduleOperationCompleted, 0)]
        [TestCase(MethodSetScheduleProperties, 0)]
        [TestCase(MethodOnSetSchedulePropertiesOperationCompleted, 0)]
        [TestCase(MethodGetScheduleProperties, 0)]
        [TestCase(MethodOnGetSchedulePropertiesOperationCompleted, 0)]
        [TestCase(MethodListScheduledReports, 0)]
        [TestCase(MethodOnListScheduledReportsOperationCompleted, 0)]
        [TestCase(MethodListSchedules, 0)]
        [TestCase(MethodOnListSchedulesOperationCompleted, 0)]
        [TestCase(MethodPauseSchedule, 0)]
        [TestCase(MethodOnPauseScheduleOperationCompleted, 0)]
        [TestCase(MethodResumeSchedule, 0)]
        [TestCase(MethodOnResumeScheduleOperationCompleted, 0)]
        [TestCase(MethodCreateSubscription, 0)]
        [TestCase(MethodOnCreateSubscriptionOperationCompleted, 0)]
        [TestCase(MethodCreateDataDrivenSubscription, 0)]
        [TestCase(MethodOnCreateDataDrivenSubscriptionOperationCompleted, 0)]
        [TestCase(MethodSetSubscriptionProperties, 0)]
        [TestCase(MethodOnSetSubscriptionPropertiesOperationCompleted, 0)]
        [TestCase(MethodSetDataDrivenSubscriptionProperties, 0)]
        [TestCase(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted, 0)]
        [TestCase(MethodGetSubscriptionProperties, 0)]
        [TestCase(MethodOnGetSubscriptionPropertiesOperationCompleted, 0)]
        [TestCase(MethodGetDataDrivenSubscriptionProperties, 0)]
        [TestCase(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted, 0)]
        [TestCase(MethodDeleteSubscription, 0)]
        [TestCase(MethodOnDeleteSubscriptionOperationCompleted, 0)]
        [TestCase(MethodPrepareQuery, 0)]
        [TestCase(MethodOnPrepareQueryOperationCompleted, 0)]
        [TestCase(MethodGetExtensionSettings, 0)]
        [TestCase(MethodOnGetExtensionSettingsOperationCompleted, 0)]
        [TestCase(MethodValidateExtensionSettings, 0)]
        [TestCase(MethodOnValidateExtensionSettingsOperationCompleted, 0)]
        [TestCase(MethodListSubscriptions, 0)]
        [TestCase(MethodOnListSubscriptionsOperationCompleted, 0)]
        [TestCase(MethodListSubscriptionsUsingDataSource, 0)]
        [TestCase(MethodOnListSubscriptionsUsingDataSourceOperationCompleted, 0)]
        [TestCase(MethodListExtensions, 0)]
        [TestCase(MethodOnListExtensionsOperationCompleted, 0)]
        [TestCase(MethodListEvents, 0)]
        [TestCase(MethodOnListEventsOperationCompleted, 0)]
        [TestCase(MethodFireEvent, 0)]
        [TestCase(MethodOnFireEventOperationCompleted, 0)]
        [TestCase(MethodListTasks, 0)]
        [TestCase(MethodOnListTasksOperationCompleted, 0)]
        [TestCase(MethodListRoles, 0)]
        [TestCase(MethodOnListRolesOperationCompleted, 0)]
        [TestCase(MethodCreateRole, 0)]
        [TestCase(MethodOnCreateRoleOperationCompleted, 0)]
        [TestCase(MethodDeleteRole, 0)]
        [TestCase(MethodOnDeleteRoleOperationCompleted, 0)]
        [TestCase(MethodGetRoleProperties, 0)]
        [TestCase(MethodOnGetRolePropertiesOperationCompleted, 0)]
        [TestCase(MethodSetRoleProperties, 0)]
        [TestCase(MethodOnSetRolePropertiesOperationCompleted, 0)]
        [TestCase(MethodGetSystemPolicies, 0)]
        [TestCase(MethodOnGetSystemPoliciesOperationCompleted, 0)]
        [TestCase(MethodSetSystemPolicies, 0)]
        [TestCase(MethodOnSetSystemPoliciesOperationCompleted, 0)]
        [TestCase(MethodGetPolicies, 0)]
        [TestCase(MethodOnGetPoliciesOperationCompleted, 0)]
        [TestCase(MethodSetPolicies, 0)]
        [TestCase(MethodOnSetPoliciesOperationCompleted, 0)]
        [TestCase(MethodInheritParentSecurity, 0)]
        [TestCase(MethodOnInheritParentSecurityOperationCompleted, 0)]
        [TestCase(MethodGetSystemPermissions, 0)]
        [TestCase(MethodOnGetSystemPermissionsOperationCompleted, 0)]
        [TestCase(MethodGetPermissions, 0)]
        [TestCase(MethodOnGetPermissionsOperationCompleted, 0)]
        [TestCase(MethodLogonUser, 0)]
        [TestCase(MethodOnLogonUserOperationCompleted, 0)]
        [TestCase(MethodLogoff, 0)]
        [TestCase(MethodOnLogoffOperationCompleted, 0)]
        [TestCase(MethodCreateModel, 0)]
        [TestCase(MethodOnCreateModelOperationCompleted, 0)]
        [TestCase(MethodGetModelDefinition, 0)]
        [TestCase(MethodOnGetModelDefinitionOperationCompleted, 0)]
        [TestCase(MethodSetModelDefinition, 0)]
        [TestCase(MethodOnSetModelDefinitionOperationCompleted, 0)]
        [TestCase(MethodListModelPerspectives, 0)]
        [TestCase(MethodOnListModelPerspectivesOperationCompleted, 0)]
        [TestCase(MethodGetUserModel, 0)]
        [TestCase(MethodOnGetUserModelOperationCompleted, 0)]
        [TestCase(MethodListModelItemChildren, 0)]
        [TestCase(MethodOnListModelItemChildrenOperationCompleted, 0)]
        [TestCase(MethodGetModelItemPermissions, 0)]
        [TestCase(MethodOnGetModelItemPermissionsOperationCompleted, 0)]
        [TestCase(MethodGetModelItemPolicies, 0)]
        [TestCase(MethodOnGetModelItemPoliciesOperationCompleted, 0)]
        [TestCase(MethodSetModelItemPolicies, 0)]
        [TestCase(MethodOnSetModelItemPoliciesOperationCompleted, 0)]
        [TestCase(MethodInheritModelItemParentSecurity, 0)]
        [TestCase(MethodOnInheritModelItemParentSecurityOperationCompleted, 0)]
        [TestCase(MethodRemoveAllModelItemPolicies, 0)]
        [TestCase(MethodOnRemoveAllModelItemPoliciesOperationCompleted, 0)]
        [TestCase(MethodSetModelDrillthroughReports, 0)]
        [TestCase(MethodOnSetModelDrillthroughReportsOperationCompleted, 0)]
        [TestCase(MethodListModelDrillthroughReports, 0)]
        [TestCase(MethodOnListModelDrillthroughReportsOperationCompleted, 0)]
        [TestCase(MethodGenerateModel, 0)]
        [TestCase(MethodOnGenerateModelOperationCompleted, 0)]
        [TestCase(MethodRegenerateModel, 0)]
        [TestCase(MethodOnRegenerateModelOperationCompleted, 0)]
        [TestCase(MethodIsLocalFileSystemWebService, 0)]
        public void AUT_ReportingService2005_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ReportingService2005) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyServerInfoHeaderValue)]
        [TestCase(PropertyBatchHeaderValue)]
        [TestCase(PropertyItemNamespaceHeaderValue)]
        [TestCase(PropertyUrl)]
        [TestCase(PropertyUseDefaultCredentials)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ReportingService2005_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ReportingService2005) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldserverInfoHeaderValueField)]
        [TestCase(FieldListSecureMethodsOperationCompleted)]
        [TestCase(FieldCreateBatchOperationCompleted)]
        [TestCase(FieldbatchHeaderValueField)]
        [TestCase(FieldCancelBatchOperationCompleted)]
        [TestCase(FieldExecuteBatchOperationCompleted)]
        [TestCase(FieldGetSystemPropertiesOperationCompleted)]
        [TestCase(FieldSetSystemPropertiesOperationCompleted)]
        [TestCase(FieldDeleteItemOperationCompleted)]
        [TestCase(FieldMoveItemOperationCompleted)]
        [TestCase(FieldListChildrenOperationCompleted)]
        [TestCase(FieldListDependentItemsOperationCompleted)]
        [TestCase(FielditemNamespaceHeaderValueField)]
        [TestCase(FieldGetPropertiesOperationCompleted)]
        [TestCase(FieldSetPropertiesOperationCompleted)]
        [TestCase(FieldGetItemTypeOperationCompleted)]
        [TestCase(FieldCreateFolderOperationCompleted)]
        [TestCase(FieldCreateReportOperationCompleted)]
        [TestCase(FieldGetReportDefinitionOperationCompleted)]
        [TestCase(FieldSetReportDefinitionOperationCompleted)]
        [TestCase(FieldCreateResourceOperationCompleted)]
        [TestCase(FieldSetResourceContentsOperationCompleted)]
        [TestCase(FieldGetResourceContentsOperationCompleted)]
        [TestCase(FieldGetReportParametersOperationCompleted)]
        [TestCase(FieldSetReportParametersOperationCompleted)]
        [TestCase(FieldCreateLinkedReportOperationCompleted)]
        [TestCase(FieldGetReportLinkOperationCompleted)]
        [TestCase(FieldSetReportLinkOperationCompleted)]
        [TestCase(FieldGetRenderResourceOperationCompleted)]
        [TestCase(FieldSetExecutionOptionsOperationCompleted)]
        [TestCase(FieldGetExecutionOptionsOperationCompleted)]
        [TestCase(FieldSetCacheOptionsOperationCompleted)]
        [TestCase(FieldGetCacheOptionsOperationCompleted)]
        [TestCase(FieldUpdateReportExecutionSnapshotOperationCompleted)]
        [TestCase(FieldFlushCacheOperationCompleted)]
        [TestCase(FieldListJobsOperationCompleted)]
        [TestCase(FieldCancelJobOperationCompleted)]
        [TestCase(FieldCreateDataSourceOperationCompleted)]
        [TestCase(FieldGetDataSourceContentsOperationCompleted)]
        [TestCase(FieldSetDataSourceContentsOperationCompleted)]
        [TestCase(FieldEnableDataSourceOperationCompleted)]
        [TestCase(FieldDisableDataSourceOperationCompleted)]
        [TestCase(FieldSetItemDataSourcesOperationCompleted)]
        [TestCase(FieldGetItemDataSourcesOperationCompleted)]
        [TestCase(FieldGetItemDataSourcePromptsOperationCompleted)]
        [TestCase(FieldCreateReportHistorySnapshotOperationCompleted)]
        [TestCase(FieldSetReportHistoryOptionsOperationCompleted)]
        [TestCase(FieldGetReportHistoryOptionsOperationCompleted)]
        [TestCase(FieldSetReportHistoryLimitOperationCompleted)]
        [TestCase(FieldGetReportHistoryLimitOperationCompleted)]
        [TestCase(FieldListReportHistoryOperationCompleted)]
        [TestCase(FieldDeleteReportHistorySnapshotOperationCompleted)]
        [TestCase(FieldFindItemsOperationCompleted)]
        [TestCase(FieldCreateScheduleOperationCompleted)]
        [TestCase(FieldDeleteScheduleOperationCompleted)]
        [TestCase(FieldSetSchedulePropertiesOperationCompleted)]
        [TestCase(FieldGetSchedulePropertiesOperationCompleted)]
        [TestCase(FieldListScheduledReportsOperationCompleted)]
        [TestCase(FieldListSchedulesOperationCompleted)]
        [TestCase(FieldPauseScheduleOperationCompleted)]
        [TestCase(FieldResumeScheduleOperationCompleted)]
        [TestCase(FieldCreateSubscriptionOperationCompleted)]
        [TestCase(FieldCreateDataDrivenSubscriptionOperationCompleted)]
        [TestCase(FieldSetSubscriptionPropertiesOperationCompleted)]
        [TestCase(FieldSetDataDrivenSubscriptionPropertiesOperationCompleted)]
        [TestCase(FieldGetSubscriptionPropertiesOperationCompleted)]
        [TestCase(FieldGetDataDrivenSubscriptionPropertiesOperationCompleted)]
        [TestCase(FieldDeleteSubscriptionOperationCompleted)]
        [TestCase(FieldPrepareQueryOperationCompleted)]
        [TestCase(FieldGetExtensionSettingsOperationCompleted)]
        [TestCase(FieldValidateExtensionSettingsOperationCompleted)]
        [TestCase(FieldListSubscriptionsOperationCompleted)]
        [TestCase(FieldListSubscriptionsUsingDataSourceOperationCompleted)]
        [TestCase(FieldListExtensionsOperationCompleted)]
        [TestCase(FieldListEventsOperationCompleted)]
        [TestCase(FieldFireEventOperationCompleted)]
        [TestCase(FieldListTasksOperationCompleted)]
        [TestCase(FieldListRolesOperationCompleted)]
        [TestCase(FieldCreateRoleOperationCompleted)]
        [TestCase(FieldDeleteRoleOperationCompleted)]
        [TestCase(FieldGetRolePropertiesOperationCompleted)]
        [TestCase(FieldSetRolePropertiesOperationCompleted)]
        [TestCase(FieldGetSystemPoliciesOperationCompleted)]
        [TestCase(FieldSetSystemPoliciesOperationCompleted)]
        [TestCase(FieldGetPoliciesOperationCompleted)]
        [TestCase(FieldSetPoliciesOperationCompleted)]
        [TestCase(FieldInheritParentSecurityOperationCompleted)]
        [TestCase(FieldGetSystemPermissionsOperationCompleted)]
        [TestCase(FieldGetPermissionsOperationCompleted)]
        [TestCase(FieldLogonUserOperationCompleted)]
        [TestCase(FieldLogoffOperationCompleted)]
        [TestCase(FieldCreateModelOperationCompleted)]
        [TestCase(FieldGetModelDefinitionOperationCompleted)]
        [TestCase(FieldSetModelDefinitionOperationCompleted)]
        [TestCase(FieldListModelPerspectivesOperationCompleted)]
        [TestCase(FieldGetUserModelOperationCompleted)]
        [TestCase(FieldListModelItemChildrenOperationCompleted)]
        [TestCase(FieldGetModelItemPermissionsOperationCompleted)]
        [TestCase(FieldGetModelItemPoliciesOperationCompleted)]
        [TestCase(FieldSetModelItemPoliciesOperationCompleted)]
        [TestCase(FieldInheritModelItemParentSecurityOperationCompleted)]
        [TestCase(FieldRemoveAllModelItemPoliciesOperationCompleted)]
        [TestCase(FieldSetModelDrillthroughReportsOperationCompleted)]
        [TestCase(FieldListModelDrillthroughReportsOperationCompleted)]
        [TestCase(FieldGenerateModelOperationCompleted)]
        [TestCase(FieldRegenerateModelOperationCompleted)]
        [TestCase(FielduseDefaultCredentialsSetExplicitly)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ReportingService2005_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ReportingService2005) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ReportingService2005_Is_Instance_Present_Test()
        {
            // Assert
            _reportingService2005InstanceType.ShouldNotBeNull();
            _reportingService2005Instance.ShouldNotBeNull();
            _reportingService2005InstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReportingService2005) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReportingService2005" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ReportingService2005_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _reportingService2005Instance.ShouldBeAssignableTo<ReportingService2005>();
            _reportingService2005InstanceFixture.ShouldBeAssignableTo<ReportingService2005>();
            CurrentInstance.ShouldBeAssignableTo<ReportingService2005>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReportingService2005) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ReportingService2005_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReportingService2005 instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ReportingService2005) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyServerInfoHeaderValue)]
        [TestCase(PropertyBatchHeaderValue)]
        [TestCase(PropertyItemNamespaceHeaderValue)]
        [TestCase(PropertyUrl)]
        [TestCase(PropertyUseDefaultCredentials)]
        public void AUT_ReportingService2005_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ReportingService2005) => Property (BatchHeaderValue) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_BatchHeaderValue_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchHeaderValue);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBatchHeaderValue);
            Action currentAction = () => propertyInfo.SetValue(_reportingService2005Instance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (BatchHeaderValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_Public_Class_BatchHeaderValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchHeaderValue);
            var propertyInfo = this.GetPropertyInfo(PropertyBatchHeaderValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (ItemNamespaceHeaderValue) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_ItemNamespaceHeaderValue_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemNamespaceHeaderValue);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyItemNamespaceHeaderValue);
            Action currentAction = () => propertyInfo.SetValue(_reportingService2005Instance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (ItemNamespaceHeaderValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_Public_Class_ItemNamespaceHeaderValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemNamespaceHeaderValue);
            var propertyInfo = this.GetPropertyInfo(PropertyItemNamespaceHeaderValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (ServerInfoHeaderValue) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_ServerInfoHeaderValue_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServerInfoHeaderValue);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyServerInfoHeaderValue);
            Action currentAction = () => propertyInfo.SetValue(_reportingService2005Instance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (ServerInfoHeaderValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_Public_Class_ServerInfoHeaderValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServerInfoHeaderValue);
            var propertyInfo = this.GetPropertyInfo(PropertyServerInfoHeaderValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (Url) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_Public_Class_Url_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUrl);
            var propertyInfo = this.GetPropertyInfo(PropertyUrl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportingService2005) => Property (UseDefaultCredentials) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportingService2005_Public_Class_UseDefaultCredentials_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUseDefaultCredentials);
            var propertyInfo = this.GetPropertyInfo(PropertyUseDefaultCredentials);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (OnLogonUserOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogonUserOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogonUserOperationCompleted);
            var methodOnLogonUserOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnLogonUserOperationCompleted, methodOnLogonUserOperationCompletedParametersTypes);

            // Assert
            methodOnLogonUserOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnLogonUserOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogonUserOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogonUserOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnLogonUserOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (Logoff) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_Logoff_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoff);

            // Act
            Action executeAction = () => _reportingService2005Instance.Logoff();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Logoff) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_Logoff_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoff);
            Type [] methodLogoffParametersTypes = null;
            object[] parametersOfLogoff = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogoff, methodLogoffParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfLogoff);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogoff.ShouldBeNull();
            methodLogoffParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Logoff) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_Logoff_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoff);
            Type [] methodLogoffParametersTypes = null;
            object[] parametersOfLogoff = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogoff, parametersOfLogoff, methodLogoffParametersTypes);

            // Assert
            parametersOfLogoff.ShouldBeNull();
            methodLogoffParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Logoff) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_Logoff_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoff);
            Type [] methodLogoffParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogoff, methodLogoffParametersTypes);

            // Assert
            methodLogoffParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Logoff) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_Logoff_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoff);
            var currentMethodInfo = this.GetMethodInfo(MethodLogoff, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnLogoffOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogoffOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogoffOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnLogoffOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnLogoffOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnLogoffOperationCompleted, methodOnLogoffOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnLogoffOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnLogoffOperationCompleted.ShouldNotBeNull();
            parametersOfOnLogoffOperationCompleted.Length.ShouldBe(1);
            methodOnLogoffOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnLogoffOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnLogoffOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnLogoffOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogoffOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogoffOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnLogoffOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnLogoffOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnLogoffOperationCompleted, parametersOfOnLogoffOperationCompleted, methodOnLogoffOperationCompletedParametersTypes);

            // Assert
            parametersOfOnLogoffOperationCompleted.ShouldNotBeNull();
            parametersOfOnLogoffOperationCompleted.Length.ShouldBe(1);
            methodOnLogoffOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnLogoffOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnLogoffOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnLogoffOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogoffOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogoffOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnLogoffOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnLogoffOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogoffOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogoffOperationCompleted);
            var methodOnLogoffOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnLogoffOperationCompleted, methodOnLogoffOperationCompletedParametersTypes);

            // Assert
            methodOnLogoffOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnLogoffOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogoffOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogoffOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnLogoffOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateModel) (Return Type : Warning[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateModel(Model, Parent, Definition, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();
            var returnedValue = default(Warning[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateModel(Model, Parent, Definition, Properties);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(byte[]), typeof(Property[]) };
            object[] parametersOfCreateModel = { Model, Parent, Definition, Properties };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateModel, methodCreateModelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Warning[]>(_reportingService2005InstanceFixture, parametersOfCreateModel);
            var result2 = this.GetResultOfMethod<Warning[]>(MethodCreateModel, parametersOfCreateModel, methodCreateModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateModel.ShouldNotBeNull();
            parametersOfCreateModel.Length.ShouldBe(4);
            methodCreateModelParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(byte[]), typeof(Property[]) };
            object[] parametersOfCreateModel = { Model, Parent, Definition, Properties };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Warning[]>(MethodCreateModel, parametersOfCreateModel, methodCreateModelParametersTypes);

            // Assert
            parametersOfCreateModel.ShouldNotBeNull();
            parametersOfCreateModel.Length.ShouldBe(4);
            methodCreateModelParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var methodCreateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(byte[]), typeof(Property[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateModel, methodCreateModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateModelParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var methodCreateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(byte[]), typeof(Property[]) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateModel, methodCreateModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateModel) (Return Type : Warning[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateModel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateModel);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateModel, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCreateModelOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateModelOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateModelOperationCompleted, methodOnCreateModelOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnCreateModelOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnCreateModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateModelOperationCompleted.Length.ShouldBe(1);
            methodOnCreateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateModelOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateModelOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateModelOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateModelOperationCompleted, parametersOfOnCreateModelOperationCompleted, methodOnCreateModelOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateModelOperationCompleted.Length.ShouldBe(1);
            methodOnCreateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateModelOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateModelOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateModelOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateModelOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateModelOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateModelOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateModelOperationCompleted);
            var methodOnCreateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateModelOperationCompleted, methodOnCreateModelOperationCompletedParametersTypes);

            // Assert
            methodOnCreateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateModelOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateModelOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateModelOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetModelDefinition) (Return Type : byte[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var Model = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetModelDefinition(Model);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var Model = this.CreateType<string>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetModelDefinition(Model);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var Model = this.CreateType<string>();
            var methodGetModelDefinitionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetModelDefinition = { Model };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelDefinition, methodGetModelDefinitionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<byte[]>(_reportingService2005InstanceFixture, parametersOfGetModelDefinition);
            var result2 = this.GetResultOfMethod<byte[]>(MethodGetModelDefinition, parametersOfGetModelDefinition, methodGetModelDefinitionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModelDefinition.ShouldNotBeNull();
            parametersOfGetModelDefinition.Length.ShouldBe(1);
            methodGetModelDefinitionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var Model = this.CreateType<string>();
            var methodGetModelDefinitionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetModelDefinition = { Model };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodGetModelDefinition, parametersOfGetModelDefinition, methodGetModelDefinitionParametersTypes);

            // Assert
            parametersOfGetModelDefinition.ShouldNotBeNull();
            parametersOfGetModelDefinition.Length.ShouldBe(1);
            methodGetModelDefinitionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var methodGetModelDefinitionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModelDefinition, methodGetModelDefinitionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModelDefinitionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var methodGetModelDefinitionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModelDefinition, methodGetModelDefinitionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModelDefinitionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelDefinition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelDefinition) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelDefinition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelDefinition, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetModelDefinitionOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetModelDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetModelDefinitionOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelDefinitionOperationCompleted, methodOnGetModelDefinitionOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetModelDefinitionOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetModelDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetModelDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnGetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetModelDefinitionOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelDefinitionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetModelDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetModelDefinitionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetModelDefinitionOperationCompleted, parametersOfOnGetModelDefinitionOperationCompleted, methodOnGetModelDefinitionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetModelDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetModelDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnGetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetModelDefinitionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelDefinitionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelDefinitionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelDefinitionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetModelDefinitionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelDefinitionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelDefinitionOperationCompleted);
            var methodOnGetModelDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetModelDefinitionOperationCompleted, methodOnGetModelDefinitionOperationCompletedParametersTypes);

            // Assert
            methodOnGetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelDefinitionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelDefinitionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelDefinitionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var Model = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetModelDefinition(Model, Definition);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var Model = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var returnedValue = default(Warning[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.SetModelDefinition(Model, Definition);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var Model = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var methodSetModelDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };
            object[] parametersOfSetModelDefinition = { Model, Definition };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelDefinition, methodSetModelDefinitionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Warning[]>(_reportingService2005InstanceFixture, parametersOfSetModelDefinition);
            var result2 = this.GetResultOfMethod<Warning[]>(MethodSetModelDefinition, parametersOfSetModelDefinition, methodSetModelDefinitionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSetModelDefinition.ShouldNotBeNull();
            parametersOfSetModelDefinition.Length.ShouldBe(2);
            methodSetModelDefinitionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var Model = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var methodSetModelDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };
            object[] parametersOfSetModelDefinition = { Model, Definition };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Warning[]>(MethodSetModelDefinition, parametersOfSetModelDefinition, methodSetModelDefinitionParametersTypes);

            // Assert
            parametersOfSetModelDefinition.ShouldNotBeNull();
            parametersOfSetModelDefinition.Length.ShouldBe(2);
            methodSetModelDefinitionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var methodSetModelDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetModelDefinition, methodSetModelDefinitionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSetModelDefinitionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var methodSetModelDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetModelDefinition, methodSetModelDefinitionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetModelDefinitionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelDefinition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetModelDefinition) (Return Type : Warning[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDefinition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelDefinition, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnSetModelDefinitionOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetModelDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetModelDefinitionOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelDefinitionOperationCompleted, methodOnSetModelDefinitionOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnSetModelDefinitionOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnSetModelDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetModelDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnSetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetModelDefinitionOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelDefinitionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetModelDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetModelDefinitionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetModelDefinitionOperationCompleted, parametersOfOnSetModelDefinitionOperationCompleted, methodOnSetModelDefinitionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetModelDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetModelDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnSetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetModelDefinitionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelDefinitionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDefinitionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelDefinitionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetModelDefinitionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDefinitionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDefinitionOperationCompleted);
            var methodOnSetModelDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetModelDefinitionOperationCompleted, methodOnSetModelDefinitionOperationCompletedParametersTypes);

            // Assert
            methodOnSetModelDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelDefinitionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDefinitionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelDefinitionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var Model = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListModelPerspectives(Model);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var Model = this.CreateType<string>();
            var returnedValue = default(ModelCatalogItem[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListModelPerspectives(Model);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var Model = this.CreateType<string>();
            var methodListModelPerspectivesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListModelPerspectives = { Model };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListModelPerspectives, methodListModelPerspectivesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ModelCatalogItem[]>(_reportingService2005InstanceFixture, parametersOfListModelPerspectives);
            var result2 = this.GetResultOfMethod<ModelCatalogItem[]>(MethodListModelPerspectives, parametersOfListModelPerspectives, methodListModelPerspectivesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListModelPerspectives.ShouldNotBeNull();
            parametersOfListModelPerspectives.Length.ShouldBe(1);
            methodListModelPerspectivesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var Model = this.CreateType<string>();
            var methodListModelPerspectivesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListModelPerspectives = { Model };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelCatalogItem[]>(MethodListModelPerspectives, parametersOfListModelPerspectives, methodListModelPerspectivesParametersTypes);

            // Assert
            parametersOfListModelPerspectives.ShouldNotBeNull();
            parametersOfListModelPerspectives.Length.ShouldBe(1);
            methodListModelPerspectivesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var methodListModelPerspectivesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListModelPerspectives, methodListModelPerspectivesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListModelPerspectivesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var methodListModelPerspectivesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListModelPerspectives, methodListModelPerspectivesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListModelPerspectivesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var currentMethodInfo = this.GetMethodInfo(MethodListModelPerspectives, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListModelPerspectives) (Return Type : ModelCatalogItem[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelPerspectives_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelPerspectives);
            var currentMethodInfo = this.GetMethodInfo(MethodListModelPerspectives, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListModelPerspectivesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelPerspectivesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelPerspectivesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListModelPerspectivesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListModelPerspectivesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelPerspectivesOperationCompleted, methodOnListModelPerspectivesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListModelPerspectivesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListModelPerspectivesOperationCompleted.ShouldNotBeNull();
            parametersOfOnListModelPerspectivesOperationCompleted.Length.ShouldBe(1);
            methodOnListModelPerspectivesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListModelPerspectivesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListModelPerspectivesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelPerspectivesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelPerspectivesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelPerspectivesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListModelPerspectivesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListModelPerspectivesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListModelPerspectivesOperationCompleted, parametersOfOnListModelPerspectivesOperationCompleted, methodOnListModelPerspectivesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListModelPerspectivesOperationCompleted.ShouldNotBeNull();
            parametersOfOnListModelPerspectivesOperationCompleted.Length.ShouldBe(1);
            methodOnListModelPerspectivesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListModelPerspectivesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListModelPerspectivesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelPerspectivesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelPerspectivesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelPerspectivesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelPerspectivesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListModelPerspectivesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelPerspectivesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelPerspectivesOperationCompleted);
            var methodOnListModelPerspectivesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListModelPerspectivesOperationCompleted, methodOnListModelPerspectivesOperationCompletedParametersTypes);

            // Assert
            methodOnListModelPerspectivesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelPerspectivesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelPerspectivesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelPerspectivesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelPerspectivesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetUserModel) (Return Type : byte[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var Model = this.CreateType<string>();
            var Perspective = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetUserModel(Model, Perspective);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var Model = this.CreateType<string>();
            var Perspective = this.CreateType<string>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetUserModel(Model, Perspective);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var Model = this.CreateType<string>();
            var Perspective = this.CreateType<string>();
            var methodGetUserModelParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUserModel = { Model, Perspective };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, methodGetUserModelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<byte[]>(_reportingService2005InstanceFixture, parametersOfGetUserModel);
            var result2 = this.GetResultOfMethod<byte[]>(MethodGetUserModel, parametersOfGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserModel.ShouldNotBeNull();
            parametersOfGetUserModel.Length.ShouldBe(2);
            methodGetUserModelParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var Model = this.CreateType<string>();
            var Perspective = this.CreateType<string>();
            var methodGetUserModelParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetUserModel = { Model, Perspective };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodGetUserModel, parametersOfGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            parametersOfGetUserModel.ShouldNotBeNull();
            parametersOfGetUserModel.Length.ShouldBe(2);
            methodGetUserModelParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var methodGetUserModelParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserModelParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var methodGetUserModelParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetUserModel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetUserModelOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetUserModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetUserModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetUserModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetUserModelOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetUserModelOperationCompleted, methodOnGetUserModelOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetUserModelOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetUserModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetUserModelOperationCompleted.Length.ShouldBe(1);
            methodOnGetUserModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetUserModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetUserModelOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetUserModelOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetUserModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetUserModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetUserModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetUserModelOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetUserModelOperationCompleted, parametersOfOnGetUserModelOperationCompleted, methodOnGetUserModelOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetUserModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetUserModelOperationCompleted.Length.ShouldBe(1);
            methodOnGetUserModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetUserModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetUserModelOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetUserModelOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetUserModelOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetUserModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetUserModelOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetUserModelOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetUserModelOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetUserModelOperationCompleted);
            var methodOnGetUserModelOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetUserModelOperationCompleted, methodOnGetUserModelOperationCompletedParametersTypes);

            // Assert
            methodOnGetUserModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetUserModelOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetUserModelOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetUserModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetUserModelOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListModelItemChildren(Model, ModelItemID, Recursive);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();
            var returnedValue = default(ModelItem[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListModelItemChildren(Model, ModelItemID, Recursive);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();
            var methodListModelItemChildrenParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfListModelItemChildren = { Model, ModelItemID, Recursive };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListModelItemChildren, methodListModelItemChildrenParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ModelItem[]>(_reportingService2005InstanceFixture, parametersOfListModelItemChildren);
            var result2 = this.GetResultOfMethod<ModelItem[]>(MethodListModelItemChildren, parametersOfListModelItemChildren, methodListModelItemChildrenParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListModelItemChildren.ShouldNotBeNull();
            parametersOfListModelItemChildren.Length.ShouldBe(3);
            methodListModelItemChildrenParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();
            var methodListModelItemChildrenParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfListModelItemChildren = { Model, ModelItemID, Recursive };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelItem[]>(MethodListModelItemChildren, parametersOfListModelItemChildren, methodListModelItemChildrenParametersTypes);

            // Assert
            parametersOfListModelItemChildren.ShouldNotBeNull();
            parametersOfListModelItemChildren.Length.ShouldBe(3);
            methodListModelItemChildrenParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var methodListModelItemChildrenParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListModelItemChildren, methodListModelItemChildrenParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListModelItemChildrenParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var methodListModelItemChildrenParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListModelItemChildren, methodListModelItemChildrenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListModelItemChildrenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodListModelItemChildren, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListModelItemChildren) (Return Type : ModelItem[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelItemChildren_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelItemChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodListModelItemChildren, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListModelItemChildrenOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelItemChildrenOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelItemChildrenOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListModelItemChildrenOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListModelItemChildrenOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelItemChildrenOperationCompleted, methodOnListModelItemChildrenOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListModelItemChildrenOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListModelItemChildrenOperationCompleted.ShouldNotBeNull();
            parametersOfOnListModelItemChildrenOperationCompleted.Length.ShouldBe(1);
            methodOnListModelItemChildrenOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListModelItemChildrenOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListModelItemChildrenOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelItemChildrenOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelItemChildrenOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelItemChildrenOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListModelItemChildrenOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListModelItemChildrenOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListModelItemChildrenOperationCompleted, parametersOfOnListModelItemChildrenOperationCompleted, methodOnListModelItemChildrenOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListModelItemChildrenOperationCompleted.ShouldNotBeNull();
            parametersOfOnListModelItemChildrenOperationCompleted.Length.ShouldBe(1);
            methodOnListModelItemChildrenOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListModelItemChildrenOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListModelItemChildrenOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelItemChildrenOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelItemChildrenOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelItemChildrenOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelItemChildrenOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListModelItemChildrenOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelItemChildrenOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelItemChildrenOperationCompleted);
            var methodOnListModelItemChildrenOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListModelItemChildrenOperationCompleted, methodOnListModelItemChildrenOperationCompletedParametersTypes);

            // Assert
            methodOnListModelItemChildrenOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelItemChildrenOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelItemChildrenOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelItemChildrenOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelItemChildrenOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetModelItemPermissions(Model, ModelItemID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var returnedValue = default(string[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetModelItemPermissions(Model, ModelItemID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var methodGetModelItemPermissionsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetModelItemPermissions = { Model, ModelItemID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelItemPermissions, methodGetModelItemPermissionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[]>(_reportingService2005InstanceFixture, parametersOfGetModelItemPermissions);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetModelItemPermissions, parametersOfGetModelItemPermissions, methodGetModelItemPermissionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModelItemPermissions.ShouldNotBeNull();
            parametersOfGetModelItemPermissions.Length.ShouldBe(2);
            methodGetModelItemPermissionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var methodGetModelItemPermissionsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetModelItemPermissions = { Model, ModelItemID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetModelItemPermissions, parametersOfGetModelItemPermissions, methodGetModelItemPermissionsParametersTypes);

            // Assert
            parametersOfGetModelItemPermissions.ShouldNotBeNull();
            parametersOfGetModelItemPermissions.Length.ShouldBe(2);
            methodGetModelItemPermissionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var methodGetModelItemPermissionsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModelItemPermissions, methodGetModelItemPermissionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModelItemPermissionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var methodGetModelItemPermissionsParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModelItemPermissions, methodGetModelItemPermissionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModelItemPermissionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelItemPermissions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelItemPermissions) (Return Type : string[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPermissions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelItemPermissions, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetModelItemPermissionsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPermissionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPermissionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetModelItemPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetModelItemPermissionsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelItemPermissionsOperationCompleted, methodOnGetModelItemPermissionsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetModelItemPermissionsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetModelItemPermissionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetModelItemPermissionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetModelItemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetModelItemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetModelItemPermissionsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelItemPermissionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPermissionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPermissionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetModelItemPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetModelItemPermissionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetModelItemPermissionsOperationCompleted, parametersOfOnGetModelItemPermissionsOperationCompleted, methodOnGetModelItemPermissionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetModelItemPermissionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetModelItemPermissionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetModelItemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetModelItemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetModelItemPermissionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelItemPermissionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPermissionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelItemPermissionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetModelItemPermissionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPermissionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPermissionsOperationCompleted);
            var methodOnGetModelItemPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetModelItemPermissionsOperationCompleted, methodOnGetModelItemPermissionsOperationCompletedParametersTypes);

            // Assert
            methodOnGetModelItemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelItemPermissionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPermissionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelItemPermissionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetModelItemPolicies(Model, ModelItemID, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var returnedValue = default(Policy[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetModelItemPolicies(Model, ModelItemID, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var InheritParent = this.CreateType<bool>();
            var methodGetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetModelItemPolicies = { Model, ModelItemID, InheritParent };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelItemPolicies, methodGetModelItemPoliciesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Policy[]>(_reportingService2005InstanceFixture, parametersOfGetModelItemPolicies);
            var result2 = this.GetResultOfMethod<Policy[]>(MethodGetModelItemPolicies, parametersOfGetModelItemPolicies, methodGetModelItemPoliciesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModelItemPolicies.ShouldNotBeNull();
            parametersOfGetModelItemPolicies.Length.ShouldBe(3);
            methodGetModelItemPoliciesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var InheritParent = this.CreateType<bool>();
            var methodGetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetModelItemPolicies = { Model, ModelItemID, InheritParent };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Policy[]>(MethodGetModelItemPolicies, parametersOfGetModelItemPolicies, methodGetModelItemPoliciesParametersTypes);

            // Assert
            parametersOfGetModelItemPolicies.ShouldNotBeNull();
            parametersOfGetModelItemPolicies.Length.ShouldBe(3);
            methodGetModelItemPoliciesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var methodGetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModelItemPolicies, methodGetModelItemPoliciesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModelItemPoliciesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var methodGetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModelItemPolicies, methodGetModelItemPoliciesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModelItemPoliciesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelItemPolicies, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelItemPolicies) (Return Type : Policy[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetModelItemPolicies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelItemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelItemPolicies, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetModelItemPoliciesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetModelItemPoliciesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelItemPoliciesOperationCompleted, methodOnGetModelItemPoliciesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetModelItemPoliciesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetModelItemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetModelItemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnGetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetModelItemPoliciesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelItemPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetModelItemPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetModelItemPoliciesOperationCompleted, parametersOfOnGetModelItemPoliciesOperationCompleted, methodOnGetModelItemPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetModelItemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetModelItemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnGetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetModelItemPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelItemPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelItemPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetModelItemPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPoliciesOperationCompleted);
            var methodOnGetModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetModelItemPoliciesOperationCompleted, methodOnGetModelItemPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnGetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetModelItemPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetModelItemPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetModelItemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetModelItemPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetModelItemPolicies) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelItemPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Policies = this.CreateType<Policy[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetModelItemPolicies(Model, ModelItemID, Policies);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetModelItemPolicies) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelItemPolicies_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Policies = this.CreateType<Policy[]>();
            var methodSetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Policy[]) };
            object[] parametersOfSetModelItemPolicies = { Model, ModelItemID, Policies };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelItemPolicies, methodSetModelItemPoliciesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetModelItemPolicies);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetModelItemPolicies.ShouldNotBeNull();
            parametersOfSetModelItemPolicies.Length.ShouldBe(3);
            methodSetModelItemPoliciesParametersTypes.Length.ShouldBe(3);
            methodSetModelItemPoliciesParametersTypes.Length.ShouldBe(parametersOfSetModelItemPolicies.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetModelItemPolicies) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelItemPolicies_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelItemPolicies);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Policies = this.CreateType<Policy[]>();
            var methodSetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Policy[]) };
            object[] parametersOfSetModelItemPolicies = { Model, ModelItemID, Policies };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetModelItemPolicies, parametersOfSetModelItemPolicies, methodSetModelItemPoliciesParametersTypes);

            // Assert
            parametersOfSetModelItemPolicies.ShouldNotBeNull();
            parametersOfSetModelItemPolicies.Length.ShouldBe(3);
            methodSetModelItemPoliciesParametersTypes.Length.ShouldBe(3);
            methodSetModelItemPoliciesParametersTypes.Length.ShouldBe(parametersOfSetModelItemPolicies.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetModelItemPolicies) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelItemPolicies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelItemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelItemPolicies, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetModelItemPolicies) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelItemPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelItemPolicies);
            var methodSetModelItemPoliciesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Policy[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetModelItemPolicies, methodSetModelItemPoliciesParametersTypes);

            // Assert
            methodSetModelItemPoliciesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetModelItemPolicies) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelItemPolicies_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelItemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelItemPolicies, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetModelItemPoliciesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelItemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelItemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetModelItemPoliciesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelItemPoliciesOperationCompleted, methodOnSetModelItemPoliciesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnSetModelItemPoliciesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnSetModelItemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetModelItemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnSetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetModelItemPoliciesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelItemPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelItemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelItemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetModelItemPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetModelItemPoliciesOperationCompleted, parametersOfOnSetModelItemPoliciesOperationCompleted, methodOnSetModelItemPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetModelItemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetModelItemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnSetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetModelItemPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelItemPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelItemPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelItemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelItemPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetModelItemPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelItemPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelItemPoliciesOperationCompleted);
            var methodOnSetModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetModelItemPoliciesOperationCompleted, methodOnSetModelItemPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnSetModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelItemPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelItemPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelItemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelItemPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (InheritModelItemParentSecurity) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritModelItemParentSecurity_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritModelItemParentSecurity);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.InheritModelItemParentSecurity(Model, ModelItemID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InheritModelItemParentSecurity) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritModelItemParentSecurity_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritModelItemParentSecurity);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var methodInheritModelItemParentSecurityParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfInheritModelItemParentSecurity = { Model, ModelItemID };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInheritModelItemParentSecurity, methodInheritModelItemParentSecurityParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfInheritModelItemParentSecurity);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInheritModelItemParentSecurity.ShouldNotBeNull();
            parametersOfInheritModelItemParentSecurity.Length.ShouldBe(2);
            methodInheritModelItemParentSecurityParametersTypes.Length.ShouldBe(2);
            methodInheritModelItemParentSecurityParametersTypes.Length.ShouldBe(parametersOfInheritModelItemParentSecurity.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InheritModelItemParentSecurity) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritModelItemParentSecurity_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritModelItemParentSecurity);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var methodInheritModelItemParentSecurityParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfInheritModelItemParentSecurity = { Model, ModelItemID };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInheritModelItemParentSecurity, parametersOfInheritModelItemParentSecurity, methodInheritModelItemParentSecurityParametersTypes);

            // Assert
            parametersOfInheritModelItemParentSecurity.ShouldNotBeNull();
            parametersOfInheritModelItemParentSecurity.Length.ShouldBe(2);
            methodInheritModelItemParentSecurityParametersTypes.Length.ShouldBe(2);
            methodInheritModelItemParentSecurityParametersTypes.Length.ShouldBe(parametersOfInheritModelItemParentSecurity.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InheritModelItemParentSecurity) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritModelItemParentSecurity_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritModelItemParentSecurity);
            var currentMethodInfo = this.GetMethodInfo(MethodInheritModelItemParentSecurity, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InheritModelItemParentSecurity) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritModelItemParentSecurity_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritModelItemParentSecurity);
            var methodInheritModelItemParentSecurityParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInheritModelItemParentSecurity, methodInheritModelItemParentSecurityParametersTypes);

            // Assert
            methodInheritModelItemParentSecurityParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InheritModelItemParentSecurity) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritModelItemParentSecurity_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritModelItemParentSecurity);
            var currentMethodInfo = this.GetMethodInfo(MethodInheritModelItemParentSecurity, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnInheritModelItemParentSecurityOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritModelItemParentSecurityOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritModelItemParentSecurityOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnInheritModelItemParentSecurityOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnInheritModelItemParentSecurityOperationCompleted, methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnInheritModelItemParentSecurityOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnInheritModelItemParentSecurityOperationCompleted.ShouldNotBeNull();
            parametersOfOnInheritModelItemParentSecurityOperationCompleted.Length.ShouldBe(1);
            methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnInheritModelItemParentSecurityOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnInheritModelItemParentSecurityOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritModelItemParentSecurityOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritModelItemParentSecurityOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnInheritModelItemParentSecurityOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnInheritModelItemParentSecurityOperationCompleted, parametersOfOnInheritModelItemParentSecurityOperationCompleted, methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes);

            // Assert
            parametersOfOnInheritModelItemParentSecurityOperationCompleted.ShouldNotBeNull();
            parametersOfOnInheritModelItemParentSecurityOperationCompleted.Length.ShouldBe(1);
            methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnInheritModelItemParentSecurityOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnInheritModelItemParentSecurityOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritModelItemParentSecurityOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritModelItemParentSecurityOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnInheritModelItemParentSecurityOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnInheritModelItemParentSecurityOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritModelItemParentSecurityOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritModelItemParentSecurityOperationCompleted);
            var methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnInheritModelItemParentSecurityOperationCompleted, methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes);

            // Assert
            methodOnInheritModelItemParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnInheritModelItemParentSecurityOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritModelItemParentSecurityOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritModelItemParentSecurityOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnInheritModelItemParentSecurityOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (RemoveAllModelItemPolicies) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RemoveAllModelItemPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllModelItemPolicies);
            var Model = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.RemoveAllModelItemPolicies(Model);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveAllModelItemPolicies) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RemoveAllModelItemPolicies_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllModelItemPolicies);
            var Model = this.CreateType<string>();
            var methodRemoveAllModelItemPoliciesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveAllModelItemPolicies = { Model };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveAllModelItemPolicies, methodRemoveAllModelItemPoliciesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfRemoveAllModelItemPolicies);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveAllModelItemPolicies.ShouldNotBeNull();
            parametersOfRemoveAllModelItemPolicies.Length.ShouldBe(1);
            methodRemoveAllModelItemPoliciesParametersTypes.Length.ShouldBe(1);
            methodRemoveAllModelItemPoliciesParametersTypes.Length.ShouldBe(parametersOfRemoveAllModelItemPolicies.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAllModelItemPolicies) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RemoveAllModelItemPolicies_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllModelItemPolicies);
            var Model = this.CreateType<string>();
            var methodRemoveAllModelItemPoliciesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveAllModelItemPolicies = { Model };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveAllModelItemPolicies, parametersOfRemoveAllModelItemPolicies, methodRemoveAllModelItemPoliciesParametersTypes);

            // Assert
            parametersOfRemoveAllModelItemPolicies.ShouldNotBeNull();
            parametersOfRemoveAllModelItemPolicies.Length.ShouldBe(1);
            methodRemoveAllModelItemPoliciesParametersTypes.Length.ShouldBe(1);
            methodRemoveAllModelItemPoliciesParametersTypes.Length.ShouldBe(parametersOfRemoveAllModelItemPolicies.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAllModelItemPolicies) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RemoveAllModelItemPolicies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllModelItemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveAllModelItemPolicies, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveAllModelItemPolicies) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RemoveAllModelItemPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllModelItemPolicies);
            var methodRemoveAllModelItemPoliciesParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveAllModelItemPolicies, methodRemoveAllModelItemPoliciesParametersTypes);

            // Assert
            methodRemoveAllModelItemPoliciesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveAllModelItemPolicies) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RemoveAllModelItemPolicies_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveAllModelItemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveAllModelItemPolicies, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnRemoveAllModelItemPoliciesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRemoveAllModelItemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveAllModelItemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRemoveAllModelItemPoliciesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnRemoveAllModelItemPoliciesOperationCompleted, methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnRemoveAllModelItemPoliciesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnRemoveAllModelItemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnRemoveAllModelItemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRemoveAllModelItemPoliciesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveAllModelItemPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRemoveAllModelItemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveAllModelItemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRemoveAllModelItemPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnRemoveAllModelItemPoliciesOperationCompleted, parametersOfOnRemoveAllModelItemPoliciesOperationCompleted, methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnRemoveAllModelItemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnRemoveAllModelItemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRemoveAllModelItemPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveAllModelItemPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRemoveAllModelItemPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveAllModelItemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRemoveAllModelItemPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRemoveAllModelItemPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRemoveAllModelItemPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveAllModelItemPoliciesOperationCompleted);
            var methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnRemoveAllModelItemPoliciesOperationCompleted, methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnRemoveAllModelItemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveAllModelItemPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRemoveAllModelItemPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveAllModelItemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRemoveAllModelItemPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetModelDrillthroughReports) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDrillthroughReports_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Reports = this.CreateType<ModelDrillthroughReport[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetModelDrillthroughReports(Model, ModelItemID, Reports);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetModelDrillthroughReports) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDrillthroughReports_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Reports = this.CreateType<ModelDrillthroughReport[]>();
            var methodSetModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ModelDrillthroughReport[]) };
            object[] parametersOfSetModelDrillthroughReports = { Model, ModelItemID, Reports };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelDrillthroughReports, methodSetModelDrillthroughReportsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetModelDrillthroughReports);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetModelDrillthroughReports.ShouldNotBeNull();
            parametersOfSetModelDrillthroughReports.Length.ShouldBe(3);
            methodSetModelDrillthroughReportsParametersTypes.Length.ShouldBe(3);
            methodSetModelDrillthroughReportsParametersTypes.Length.ShouldBe(parametersOfSetModelDrillthroughReports.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetModelDrillthroughReports) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDrillthroughReports_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var Reports = this.CreateType<ModelDrillthroughReport[]>();
            var methodSetModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ModelDrillthroughReport[]) };
            object[] parametersOfSetModelDrillthroughReports = { Model, ModelItemID, Reports };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetModelDrillthroughReports, parametersOfSetModelDrillthroughReports, methodSetModelDrillthroughReportsParametersTypes);

            // Assert
            parametersOfSetModelDrillthroughReports.ShouldNotBeNull();
            parametersOfSetModelDrillthroughReports.Length.ShouldBe(3);
            methodSetModelDrillthroughReportsParametersTypes.Length.ShouldBe(3);
            methodSetModelDrillthroughReportsParametersTypes.Length.ShouldBe(parametersOfSetModelDrillthroughReports.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetModelDrillthroughReports) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDrillthroughReports_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDrillthroughReports);
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelDrillthroughReports, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetModelDrillthroughReports) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDrillthroughReports_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDrillthroughReports);
            var methodSetModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ModelDrillthroughReport[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetModelDrillthroughReports, methodSetModelDrillthroughReportsParametersTypes);

            // Assert
            methodSetModelDrillthroughReportsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetModelDrillthroughReports) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetModelDrillthroughReports_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetModelDrillthroughReports);
            var currentMethodInfo = this.GetMethodInfo(MethodSetModelDrillthroughReports, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetModelDrillthroughReportsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDrillthroughReportsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDrillthroughReportsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetModelDrillthroughReportsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelDrillthroughReportsOperationCompleted, methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnSetModelDrillthroughReportsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnSetModelDrillthroughReportsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetModelDrillthroughReportsOperationCompleted.Length.ShouldBe(1);
            methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetModelDrillthroughReportsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelDrillthroughReportsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDrillthroughReportsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDrillthroughReportsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetModelDrillthroughReportsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetModelDrillthroughReportsOperationCompleted, parametersOfOnSetModelDrillthroughReportsOperationCompleted, methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetModelDrillthroughReportsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetModelDrillthroughReportsOperationCompleted.Length.ShouldBe(1);
            methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetModelDrillthroughReportsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelDrillthroughReportsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDrillthroughReportsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDrillthroughReportsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelDrillthroughReportsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetModelDrillthroughReportsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDrillthroughReportsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDrillthroughReportsOperationCompleted);
            var methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetModelDrillthroughReportsOperationCompleted, methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes);

            // Assert
            methodOnSetModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetModelDrillthroughReportsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetModelDrillthroughReportsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetModelDrillthroughReportsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetModelDrillthroughReportsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListModelDrillthroughReports(Model, ModelItemID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var returnedValue = default(ModelDrillthroughReport[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListModelDrillthroughReports(Model, ModelItemID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var methodListModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfListModelDrillthroughReports = { Model, ModelItemID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListModelDrillthroughReports, methodListModelDrillthroughReportsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ModelDrillthroughReport[]>(_reportingService2005InstanceFixture, parametersOfListModelDrillthroughReports);
            var result2 = this.GetResultOfMethod<ModelDrillthroughReport[]>(MethodListModelDrillthroughReports, parametersOfListModelDrillthroughReports, methodListModelDrillthroughReportsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListModelDrillthroughReports.ShouldNotBeNull();
            parametersOfListModelDrillthroughReports.Length.ShouldBe(2);
            methodListModelDrillthroughReportsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var Model = this.CreateType<string>();
            var ModelItemID = this.CreateType<string>();
            var methodListModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfListModelDrillthroughReports = { Model, ModelItemID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelDrillthroughReport[]>(MethodListModelDrillthroughReports, parametersOfListModelDrillthroughReports, methodListModelDrillthroughReportsParametersTypes);

            // Assert
            parametersOfListModelDrillthroughReports.ShouldNotBeNull();
            parametersOfListModelDrillthroughReports.Length.ShouldBe(2);
            methodListModelDrillthroughReportsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var methodListModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListModelDrillthroughReports, methodListModelDrillthroughReportsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListModelDrillthroughReportsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var methodListModelDrillthroughReportsParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListModelDrillthroughReports, methodListModelDrillthroughReportsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListModelDrillthroughReportsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var currentMethodInfo = this.GetMethodInfo(MethodListModelDrillthroughReports, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListModelDrillthroughReports) (Return Type : ModelDrillthroughReport[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListModelDrillthroughReports_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListModelDrillthroughReports);
            var currentMethodInfo = this.GetMethodInfo(MethodListModelDrillthroughReports, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListModelDrillthroughReportsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelDrillthroughReportsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelDrillthroughReportsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListModelDrillthroughReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListModelDrillthroughReportsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelDrillthroughReportsOperationCompleted, methodOnListModelDrillthroughReportsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListModelDrillthroughReportsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListModelDrillthroughReportsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListModelDrillthroughReportsOperationCompleted.Length.ShouldBe(1);
            methodOnListModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListModelDrillthroughReportsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelDrillthroughReportsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelDrillthroughReportsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelDrillthroughReportsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListModelDrillthroughReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListModelDrillthroughReportsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListModelDrillthroughReportsOperationCompleted, parametersOfOnListModelDrillthroughReportsOperationCompleted, methodOnListModelDrillthroughReportsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListModelDrillthroughReportsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListModelDrillthroughReportsOperationCompleted.Length.ShouldBe(1);
            methodOnListModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListModelDrillthroughReportsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelDrillthroughReportsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelDrillthroughReportsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelDrillthroughReportsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelDrillthroughReportsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListModelDrillthroughReportsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelDrillthroughReportsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelDrillthroughReportsOperationCompleted);
            var methodOnListModelDrillthroughReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListModelDrillthroughReportsOperationCompleted, methodOnListModelDrillthroughReportsOperationCompletedParametersTypes);

            // Assert
            methodOnListModelDrillthroughReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListModelDrillthroughReportsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListModelDrillthroughReportsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListModelDrillthroughReportsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListModelDrillthroughReportsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GenerateModel) (Return Type : Warning[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var DataSource = this.CreateType<string>();
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GenerateModel(DataSource, Model, Parent, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var DataSource = this.CreateType<string>();
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var returnedValue = default(Warning[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GenerateModel(DataSource, Model, Parent, Properties);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var DataSource = this.CreateType<string>();
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodGenerateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };
            object[] parametersOfGenerateModel = { DataSource, Model, Parent, Properties };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateModel, methodGenerateModelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Warning[]>(_reportingService2005InstanceFixture, parametersOfGenerateModel);
            var result2 = this.GetResultOfMethod<Warning[]>(MethodGenerateModel, parametersOfGenerateModel, methodGenerateModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateModel.ShouldNotBeNull();
            parametersOfGenerateModel.Length.ShouldBe(4);
            methodGenerateModelParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var DataSource = this.CreateType<string>();
            var Model = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodGenerateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };
            object[] parametersOfGenerateModel = { DataSource, Model, Parent, Properties };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Warning[]>(MethodGenerateModel, parametersOfGenerateModel, methodGenerateModelParametersTypes);

            // Assert
            parametersOfGenerateModel.ShouldNotBeNull();
            parametersOfGenerateModel.Length.ShouldBe(4);
            methodGenerateModelParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var methodGenerateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateModel, methodGenerateModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateModelParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var methodGenerateModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateModel, methodGenerateModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateModel) (Return Type : Warning[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GenerateModel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateModel, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGenerateModelOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGenerateModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGenerateModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGenerateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGenerateModelOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGenerateModelOperationCompleted, methodOnGenerateModelOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGenerateModelOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGenerateModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnGenerateModelOperationCompleted.Length.ShouldBe(1);
            methodOnGenerateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGenerateModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGenerateModelOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGenerateModelOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGenerateModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGenerateModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGenerateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGenerateModelOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGenerateModelOperationCompleted, parametersOfOnGenerateModelOperationCompleted, methodOnGenerateModelOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGenerateModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnGenerateModelOperationCompleted.Length.ShouldBe(1);
            methodOnGenerateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGenerateModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGenerateModelOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGenerateModelOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGenerateModelOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGenerateModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGenerateModelOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGenerateModelOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGenerateModelOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGenerateModelOperationCompleted);
            var methodOnGenerateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGenerateModelOperationCompleted, methodOnGenerateModelOperationCompletedParametersTypes);

            // Assert
            methodOnGenerateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGenerateModelOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGenerateModelOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGenerateModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGenerateModelOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (RegenerateModel) (Return Type : Warning[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var Model = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.RegenerateModel(Model);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var Model = this.CreateType<string>();
            var returnedValue = default(Warning[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.RegenerateModel(Model);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var Model = this.CreateType<string>();
            var methodRegenerateModelParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRegenerateModel = { Model };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRegenerateModel, methodRegenerateModelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Warning[]>(_reportingService2005InstanceFixture, parametersOfRegenerateModel);
            var result2 = this.GetResultOfMethod<Warning[]>(MethodRegenerateModel, parametersOfRegenerateModel, methodRegenerateModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRegenerateModel.ShouldNotBeNull();
            parametersOfRegenerateModel.Length.ShouldBe(1);
            methodRegenerateModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var Model = this.CreateType<string>();
            var methodRegenerateModelParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRegenerateModel = { Model };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Warning[]>(MethodRegenerateModel, parametersOfRegenerateModel, methodRegenerateModelParametersTypes);

            // Assert
            parametersOfRegenerateModel.ShouldNotBeNull();
            parametersOfRegenerateModel.Length.ShouldBe(1);
            methodRegenerateModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var methodRegenerateModelParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRegenerateModel, methodRegenerateModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRegenerateModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var methodRegenerateModelParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegenerateModel, methodRegenerateModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRegenerateModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var currentMethodInfo = this.GetMethodInfo(MethodRegenerateModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RegenerateModel) (Return Type : Warning[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_RegenerateModel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegenerateModel);
            var currentMethodInfo = this.GetMethodInfo(MethodRegenerateModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnRegenerateModelOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRegenerateModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRegenerateModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRegenerateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRegenerateModelOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnRegenerateModelOperationCompleted, methodOnRegenerateModelOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnRegenerateModelOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnRegenerateModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnRegenerateModelOperationCompleted.Length.ShouldBe(1);
            methodOnRegenerateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRegenerateModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRegenerateModelOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnRegenerateModelOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRegenerateModelOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRegenerateModelOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRegenerateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRegenerateModelOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnRegenerateModelOperationCompleted, parametersOfOnRegenerateModelOperationCompleted, methodOnRegenerateModelOperationCompletedParametersTypes);

            // Assert
            parametersOfOnRegenerateModelOperationCompleted.ShouldNotBeNull();
            parametersOfOnRegenerateModelOperationCompleted.Length.ShouldBe(1);
            methodOnRegenerateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRegenerateModelOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRegenerateModelOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRegenerateModelOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRegenerateModelOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRegenerateModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRegenerateModelOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRegenerateModelOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRegenerateModelOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRegenerateModelOperationCompleted);
            var methodOnRegenerateModelOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnRegenerateModelOperationCompleted, methodOnRegenerateModelOperationCompletedParametersTypes);

            // Assert
            methodOnRegenerateModelOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRegenerateModelOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnRegenerateModelOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRegenerateModelOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRegenerateModelOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_IsLocalFileSystemWebService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_reportingService2005InstanceFixture, parametersOfIsLocalFileSystemWebService);
            var result2 = this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion
        
        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_IsLocalFileSystemWebService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_IsLocalFileSystemWebService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_IsLocalFileSystemWebService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_IsLocalFileSystemWebService_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, 0);
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