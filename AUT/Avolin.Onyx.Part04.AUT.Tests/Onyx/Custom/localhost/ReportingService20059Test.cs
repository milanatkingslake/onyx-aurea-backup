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
    public partial class ReportingService20059Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20059Test() : base(typeof(ReportingService2005))
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

        #region Method Call : (OnSetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted);
            var methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted, methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetSubscriptionProperties) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetSubscriptionProperties(SubscriptionID, out _, out _, out _, out _, out _, out _, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetSubscriptionProperties(SubscriptionID, out _, out _, out _, out _, out _, out _, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var Active = this.CreateType<ActiveState>();
            var Status = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var methodGetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            object[] parametersOfGetSubscriptionProperties = { SubscriptionID, ExtensionSettings, Description, Active, Status, EventType, MatchData, Parameters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscriptionProperties, methodGetSubscriptionPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfGetSubscriptionProperties);
            var result2 = this.GetResultOfMethod<string>(MethodGetSubscriptionProperties, parametersOfGetSubscriptionProperties, methodGetSubscriptionPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscriptionProperties.ShouldNotBeNull();
            parametersOfGetSubscriptionProperties.Length.ShouldBe(8);
            methodGetSubscriptionPropertiesParametersTypes.Length.ShouldBe(8);
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var Active = this.CreateType<ActiveState>();
            var Status = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var methodGetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            object[] parametersOfGetSubscriptionProperties = { SubscriptionID, ExtensionSettings, Description, Active, Status, EventType, MatchData, Parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSubscriptionProperties, parametersOfGetSubscriptionProperties, methodGetSubscriptionPropertiesParametersTypes);

            // Assert
            parametersOfGetSubscriptionProperties.ShouldNotBeNull();
            parametersOfGetSubscriptionProperties.Length.ShouldBe(8);
            methodGetSubscriptionPropertiesParametersTypes.Length.ShouldBe(8);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var methodGetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscriptionProperties, methodGetSubscriptionPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscriptionPropertiesParametersTypes.Length.ShouldBe(8);
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var methodGetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            const int parametersCount = 8;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscriptionProperties, methodGetSubscriptionPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscriptionPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscriptionProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscriptionProperties) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSubscriptionProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscriptionProperties, 0);
            const int parametersCount = 8;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetSubscriptionPropertiesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSubscriptionPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSubscriptionPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSubscriptionPropertiesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSubscriptionPropertiesOperationCompleted, methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetSubscriptionPropertiesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetSubscriptionPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSubscriptionPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSubscriptionPropertiesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSubscriptionPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSubscriptionPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSubscriptionPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSubscriptionPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSubscriptionPropertiesOperationCompleted, parametersOfOnGetSubscriptionPropertiesOperationCompleted, methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSubscriptionPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSubscriptionPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSubscriptionPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSubscriptionPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSubscriptionPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSubscriptionPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSubscriptionPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSubscriptionPropertiesOperationCompleted);
            var methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSubscriptionPropertiesOperationCompleted, methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSubscriptionPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSubscriptionPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetDataDrivenSubscriptionProperties(DataDrivenSubscriptionID, out _, out _, out _, out _, out _, out _, out _, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetDataDrivenSubscriptionProperties(DataDrivenSubscriptionID, out _, out _, out _, out _, out _, out _, out _, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var Active = this.CreateType<ActiveState>();
            var Status = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodGetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfGetDataDrivenSubscriptionProperties = { DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, Active, Status, EventType, MatchData, Parameters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataDrivenSubscriptionProperties, methodGetDataDrivenSubscriptionPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfGetDataDrivenSubscriptionProperties);
            var result2 = this.GetResultOfMethod<string>(MethodGetDataDrivenSubscriptionProperties, parametersOfGetDataDrivenSubscriptionProperties, methodGetDataDrivenSubscriptionPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDataDrivenSubscriptionProperties.ShouldNotBeNull();
            parametersOfGetDataDrivenSubscriptionProperties.Length.ShouldBe(9);
            methodGetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(9);
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var Active = this.CreateType<ActiveState>();
            var Status = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodGetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfGetDataDrivenSubscriptionProperties = { DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, Active, Status, EventType, MatchData, Parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDataDrivenSubscriptionProperties, parametersOfGetDataDrivenSubscriptionProperties, methodGetDataDrivenSubscriptionPropertiesParametersTypes);

            // Assert
            parametersOfGetDataDrivenSubscriptionProperties.ShouldNotBeNull();
            parametersOfGetDataDrivenSubscriptionProperties.Length.ShouldBe(9);
            methodGetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(9);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var methodGetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataDrivenSubscriptionProperties, methodGetDataDrivenSubscriptionPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(9);
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var methodGetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(ActiveState), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            const int parametersCount = 9;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataDrivenSubscriptionProperties, methodGetDataDrivenSubscriptionPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataDrivenSubscriptionProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataDrivenSubscriptionProperties) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataDrivenSubscriptionProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataDrivenSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataDrivenSubscriptionProperties, 0);
            const int parametersCount = 9;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted, methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted, parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted, methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetDataDrivenSubscriptionPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            var methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted, methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetDataDrivenSubscriptionPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (DeleteSubscription) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var SubscriptionID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.DeleteSubscription(SubscriptionID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSubscription_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var SubscriptionID = this.CreateType<string>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteSubscription = { SubscriptionID };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfDeleteSubscription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteSubscription.ShouldNotBeNull();
            parametersOfDeleteSubscription.Length.ShouldBe(1);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(1);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(parametersOfDeleteSubscription.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSubscription_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var SubscriptionID = this.CreateType<string>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteSubscription = { SubscriptionID };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            parametersOfDeleteSubscription.ShouldNotBeNull();
            parametersOfDeleteSubscription.Length.ShouldBe(1);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(1);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(parametersOfDeleteSubscription.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSubscription_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnDeleteSubscriptionOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteSubscriptionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteSubscriptionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDeleteSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDeleteSubscriptionOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteSubscriptionOperationCompleted, methodOnDeleteSubscriptionOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnDeleteSubscriptionOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnDeleteSubscriptionOperationCompleted.ShouldNotBeNull();
            parametersOfOnDeleteSubscriptionOperationCompleted.Length.ShouldBe(1);
            methodOnDeleteSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDeleteSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDeleteSubscriptionOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteSubscriptionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteSubscriptionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteSubscriptionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDeleteSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDeleteSubscriptionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnDeleteSubscriptionOperationCompleted, parametersOfOnDeleteSubscriptionOperationCompleted, methodOnDeleteSubscriptionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnDeleteSubscriptionOperationCompleted.ShouldNotBeNull();
            parametersOfOnDeleteSubscriptionOperationCompleted.Length.ShouldBe(1);
            methodOnDeleteSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDeleteSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDeleteSubscriptionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteSubscriptionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteSubscriptionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteSubscriptionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteSubscriptionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnDeleteSubscriptionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteSubscriptionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteSubscriptionOperationCompleted);
            var methodOnDeleteSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnDeleteSubscriptionOperationCompleted, methodOnDeleteSubscriptionOperationCompletedParametersTypes);

            // Assert
            methodOnDeleteSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteSubscriptionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteSubscriptionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteSubscriptionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteSubscriptionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var DataSource = this.CreateType<DataSource>();
            var DataSet = this.CreateType<DataSetDefinition>();

            // Act
            Action executeAction = () => _reportingService2005Instance.PrepareQuery(DataSource, DataSet, out _, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var DataSource = this.CreateType<DataSource>();
            var DataSet = this.CreateType<DataSetDefinition>();
            var returnedValue = default(DataSetDefinition);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.PrepareQuery(DataSource, DataSet, out _, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var DataSource = this.CreateType<DataSource>();
            var DataSet = this.CreateType<DataSetDefinition>();
            var Changed = this.CreateType<bool>();
            var ParameterNames = this.CreateType<string[]>();
            var methodPrepareQueryParametersTypes = new Type[] { typeof(DataSource), typeof(DataSetDefinition), typeof(bool), typeof(string[]) };
            object[] parametersOfPrepareQuery = { DataSource, DataSet, Changed, ParameterNames };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareQuery, methodPrepareQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DataSetDefinition>(_reportingService2005InstanceFixture, parametersOfPrepareQuery);
            var result2 = this.GetResultOfMethod<DataSetDefinition>(MethodPrepareQuery, parametersOfPrepareQuery, methodPrepareQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPrepareQuery.ShouldNotBeNull();
            parametersOfPrepareQuery.Length.ShouldBe(4);
            methodPrepareQueryParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var DataSource = this.CreateType<DataSource>();
            var DataSet = this.CreateType<DataSetDefinition>();
            var Changed = this.CreateType<bool>();
            var ParameterNames = this.CreateType<string[]>();
            var methodPrepareQueryParametersTypes = new Type[] { typeof(DataSource), typeof(DataSetDefinition), typeof(bool), typeof(string[]) };
            object[] parametersOfPrepareQuery = { DataSource, DataSet, Changed, ParameterNames };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DataSetDefinition>(MethodPrepareQuery, parametersOfPrepareQuery, methodPrepareQueryParametersTypes);

            // Assert
            parametersOfPrepareQuery.ShouldNotBeNull();
            parametersOfPrepareQuery.Length.ShouldBe(4);
            methodPrepareQueryParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var methodPrepareQueryParametersTypes = new Type[] { typeof(DataSource), typeof(DataSetDefinition), typeof(bool), typeof(string[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPrepareQuery, methodPrepareQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPrepareQueryParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var methodPrepareQueryParametersTypes = new Type[] { typeof(DataSource), typeof(DataSetDefinition), typeof(bool), typeof(string[]) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrepareQuery, methodPrepareQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPrepareQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PrepareQuery) (Return Type : DataSetDefinition) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PrepareQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareQuery, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnPrepareQueryOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPrepareQueryOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPrepareQueryOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnPrepareQueryOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnPrepareQueryOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnPrepareQueryOperationCompleted, methodOnPrepareQueryOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnPrepareQueryOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnPrepareQueryOperationCompleted.ShouldNotBeNull();
            parametersOfOnPrepareQueryOperationCompleted.Length.ShouldBe(1);
            methodOnPrepareQueryOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnPrepareQueryOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnPrepareQueryOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnPrepareQueryOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPrepareQueryOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPrepareQueryOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnPrepareQueryOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnPrepareQueryOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnPrepareQueryOperationCompleted, parametersOfOnPrepareQueryOperationCompleted, methodOnPrepareQueryOperationCompletedParametersTypes);

            // Assert
            parametersOfOnPrepareQueryOperationCompleted.ShouldNotBeNull();
            parametersOfOnPrepareQueryOperationCompleted.Length.ShouldBe(1);
            methodOnPrepareQueryOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnPrepareQueryOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnPrepareQueryOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnPrepareQueryOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPrepareQueryOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPrepareQueryOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnPrepareQueryOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnPrepareQueryOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPrepareQueryOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPrepareQueryOperationCompleted);
            var methodOnPrepareQueryOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnPrepareQueryOperationCompleted, methodOnPrepareQueryOperationCompletedParametersTypes);

            // Assert
            methodOnPrepareQueryOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnPrepareQueryOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPrepareQueryOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPrepareQueryOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnPrepareQueryOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var Extension = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetExtensionSettings(Extension);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var Extension = this.CreateType<string>();
            var returnedValue = default(ExtensionParameter[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetExtensionSettings(Extension);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var Extension = this.CreateType<string>();
            var methodGetExtensionSettingsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetExtensionSettings = { Extension };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetExtensionSettings, methodGetExtensionSettingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ExtensionParameter[]>(_reportingService2005InstanceFixture, parametersOfGetExtensionSettings);
            var result2 = this.GetResultOfMethod<ExtensionParameter[]>(MethodGetExtensionSettings, parametersOfGetExtensionSettings, methodGetExtensionSettingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetExtensionSettings.ShouldNotBeNull();
            parametersOfGetExtensionSettings.Length.ShouldBe(1);
            methodGetExtensionSettingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var Extension = this.CreateType<string>();
            var methodGetExtensionSettingsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetExtensionSettings = { Extension };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ExtensionParameter[]>(MethodGetExtensionSettings, parametersOfGetExtensionSettings, methodGetExtensionSettingsParametersTypes);

            // Assert
            parametersOfGetExtensionSettings.ShouldNotBeNull();
            parametersOfGetExtensionSettings.Length.ShouldBe(1);
            methodGetExtensionSettingsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var methodGetExtensionSettingsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetExtensionSettings, methodGetExtensionSettingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetExtensionSettingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var methodGetExtensionSettingsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetExtensionSettings, methodGetExtensionSettingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetExtensionSettingsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExtensionSettings, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExtensionSettings) (Return Type : ExtensionParameter[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExtensionSettings_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExtensionSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExtensionSettings, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetExtensionSettingsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExtensionSettingsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExtensionSettingsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetExtensionSettingsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetExtensionSettingsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetExtensionSettingsOperationCompleted, methodOnGetExtensionSettingsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnGetExtensionSettingsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetExtensionSettingsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetExtensionSettingsOperationCompleted.Length.ShouldBe(1);
            methodOnGetExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetExtensionSettingsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetExtensionSettingsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExtensionSettingsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExtensionSettingsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetExtensionSettingsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetExtensionSettingsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetExtensionSettingsOperationCompleted, parametersOfOnGetExtensionSettingsOperationCompleted, methodOnGetExtensionSettingsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetExtensionSettingsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetExtensionSettingsOperationCompleted.Length.ShouldBe(1);
            methodOnGetExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetExtensionSettingsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetExtensionSettingsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExtensionSettingsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExtensionSettingsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetExtensionSettingsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetExtensionSettingsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExtensionSettingsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExtensionSettingsOperationCompleted);
            var methodOnGetExtensionSettingsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetExtensionSettingsOperationCompleted, methodOnGetExtensionSettingsOperationCompletedParametersTypes);

            // Assert
            methodOnGetExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetExtensionSettingsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExtensionSettingsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExtensionSettingsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetExtensionSettingsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var Extension = this.CreateType<string>();
            var ParameterValues = this.CreateType<ParameterValueOrFieldReference[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ValidateExtensionSettings(Extension, ParameterValues);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var Extension = this.CreateType<string>();
            var ParameterValues = this.CreateType<ParameterValueOrFieldReference[]>();
            var returnedValue = default(ExtensionParameter[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ValidateExtensionSettings(Extension, ParameterValues);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var Extension = this.CreateType<string>();
            var ParameterValues = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodValidateExtensionSettingsParametersTypes = new Type[] { typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfValidateExtensionSettings = { Extension, ParameterValues };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateExtensionSettings, methodValidateExtensionSettingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ExtensionParameter[]>(_reportingService2005InstanceFixture, parametersOfValidateExtensionSettings);
            var result2 = this.GetResultOfMethod<ExtensionParameter[]>(MethodValidateExtensionSettings, parametersOfValidateExtensionSettings, methodValidateExtensionSettingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfValidateExtensionSettings.ShouldNotBeNull();
            parametersOfValidateExtensionSettings.Length.ShouldBe(2);
            methodValidateExtensionSettingsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var Extension = this.CreateType<string>();
            var ParameterValues = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodValidateExtensionSettingsParametersTypes = new Type[] { typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfValidateExtensionSettings = { Extension, ParameterValues };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ExtensionParameter[]>(MethodValidateExtensionSettings, parametersOfValidateExtensionSettings, methodValidateExtensionSettingsParametersTypes);

            // Assert
            parametersOfValidateExtensionSettings.ShouldNotBeNull();
            parametersOfValidateExtensionSettings.Length.ShouldBe(2);
            methodValidateExtensionSettingsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var methodValidateExtensionSettingsParametersTypes = new Type[] { typeof(string), typeof(ParameterValueOrFieldReference[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateExtensionSettings, methodValidateExtensionSettingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodValidateExtensionSettingsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var methodValidateExtensionSettingsParametersTypes = new Type[] { typeof(string), typeof(ParameterValueOrFieldReference[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateExtensionSettings, methodValidateExtensionSettingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateExtensionSettingsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateExtensionSettings, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateExtensionSettings) (Return Type : ExtensionParameter[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ValidateExtensionSettings_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateExtensionSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateExtensionSettings, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnValidateExtensionSettingsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnValidateExtensionSettingsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnValidateExtensionSettingsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnValidateExtensionSettingsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnValidateExtensionSettingsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnValidateExtensionSettingsOperationCompleted, methodOnValidateExtensionSettingsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnValidateExtensionSettingsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnValidateExtensionSettingsOperationCompleted.ShouldNotBeNull();
            parametersOfOnValidateExtensionSettingsOperationCompleted.Length.ShouldBe(1);
            methodOnValidateExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnValidateExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnValidateExtensionSettingsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnValidateExtensionSettingsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnValidateExtensionSettingsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnValidateExtensionSettingsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnValidateExtensionSettingsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnValidateExtensionSettingsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnValidateExtensionSettingsOperationCompleted, parametersOfOnValidateExtensionSettingsOperationCompleted, methodOnValidateExtensionSettingsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnValidateExtensionSettingsOperationCompleted.ShouldNotBeNull();
            parametersOfOnValidateExtensionSettingsOperationCompleted.Length.ShouldBe(1);
            methodOnValidateExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnValidateExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnValidateExtensionSettingsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnValidateExtensionSettingsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnValidateExtensionSettingsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnValidateExtensionSettingsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnValidateExtensionSettingsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnValidateExtensionSettingsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnValidateExtensionSettingsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnValidateExtensionSettingsOperationCompleted);
            var methodOnValidateExtensionSettingsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnValidateExtensionSettingsOperationCompleted, methodOnValidateExtensionSettingsOperationCompletedParametersTypes);

            // Assert
            methodOnValidateExtensionSettingsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnValidateExtensionSettingsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnValidateExtensionSettingsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnValidateExtensionSettingsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnValidateExtensionSettingsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var Report = this.CreateType<string>();
            var Owner = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListSubscriptions(Report, Owner);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var Report = this.CreateType<string>();
            var Owner = this.CreateType<string>();
            var returnedValue = default(Subscription[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListSubscriptions(Report, Owner);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var Report = this.CreateType<string>();
            var Owner = this.CreateType<string>();
            var methodListSubscriptionsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfListSubscriptions = { Report, Owner };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListSubscriptions, methodListSubscriptionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Subscription[]>(_reportingService2005InstanceFixture, parametersOfListSubscriptions);
            var result2 = this.GetResultOfMethod<Subscription[]>(MethodListSubscriptions, parametersOfListSubscriptions, methodListSubscriptionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListSubscriptions.ShouldNotBeNull();
            parametersOfListSubscriptions.Length.ShouldBe(2);
            methodListSubscriptionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var Report = this.CreateType<string>();
            var Owner = this.CreateType<string>();
            var methodListSubscriptionsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfListSubscriptions = { Report, Owner };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Subscription[]>(MethodListSubscriptions, parametersOfListSubscriptions, methodListSubscriptionsParametersTypes);

            // Assert
            parametersOfListSubscriptions.ShouldNotBeNull();
            parametersOfListSubscriptions.Length.ShouldBe(2);
            methodListSubscriptionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var methodListSubscriptionsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListSubscriptions, methodListSubscriptionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListSubscriptionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var methodListSubscriptionsParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListSubscriptions, methodListSubscriptionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListSubscriptionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var currentMethodInfo = this.GetMethodInfo(MethodListSubscriptions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSubscriptions) (Return Type : Subscription[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptions);
            var currentMethodInfo = this.GetMethodInfo(MethodListSubscriptions, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListSubscriptionsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListSubscriptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListSubscriptionsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSubscriptionsOperationCompleted, methodOnListSubscriptionsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListSubscriptionsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListSubscriptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListSubscriptionsOperationCompleted.Length.ShouldBe(1);
            methodOnListSubscriptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListSubscriptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListSubscriptionsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListSubscriptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListSubscriptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListSubscriptionsOperationCompleted, parametersOfOnListSubscriptionsOperationCompleted, methodOnListSubscriptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListSubscriptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListSubscriptionsOperationCompleted.Length.ShouldBe(1);
            methodOnListSubscriptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListSubscriptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListSubscriptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSubscriptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsOperationCompleted);
            var methodOnListSubscriptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListSubscriptionsOperationCompleted, methodOnListSubscriptionsOperationCompletedParametersTypes);

            // Assert
            methodOnListSubscriptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSubscriptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var DataSource = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListSubscriptionsUsingDataSource(DataSource);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var DataSource = this.CreateType<string>();
            var returnedValue = default(Subscription[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListSubscriptionsUsingDataSource(DataSource);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var DataSource = this.CreateType<string>();
            var methodListSubscriptionsUsingDataSourceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListSubscriptionsUsingDataSource = { DataSource };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListSubscriptionsUsingDataSource, methodListSubscriptionsUsingDataSourceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Subscription[]>(_reportingService2005InstanceFixture, parametersOfListSubscriptionsUsingDataSource);
            var result2 = this.GetResultOfMethod<Subscription[]>(MethodListSubscriptionsUsingDataSource, parametersOfListSubscriptionsUsingDataSource, methodListSubscriptionsUsingDataSourceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListSubscriptionsUsingDataSource.ShouldNotBeNull();
            parametersOfListSubscriptionsUsingDataSource.Length.ShouldBe(1);
            methodListSubscriptionsUsingDataSourceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var DataSource = this.CreateType<string>();
            var methodListSubscriptionsUsingDataSourceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListSubscriptionsUsingDataSource = { DataSource };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Subscription[]>(MethodListSubscriptionsUsingDataSource, parametersOfListSubscriptionsUsingDataSource, methodListSubscriptionsUsingDataSourceParametersTypes);

            // Assert
            parametersOfListSubscriptionsUsingDataSource.ShouldNotBeNull();
            parametersOfListSubscriptionsUsingDataSource.Length.ShouldBe(1);
            methodListSubscriptionsUsingDataSourceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var methodListSubscriptionsUsingDataSourceParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListSubscriptionsUsingDataSource, methodListSubscriptionsUsingDataSourceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListSubscriptionsUsingDataSourceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var methodListSubscriptionsUsingDataSourceParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListSubscriptionsUsingDataSource, methodListSubscriptionsUsingDataSourceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListSubscriptionsUsingDataSourceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodListSubscriptionsUsingDataSource, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSubscriptionsUsingDataSource) (Return Type : Subscription[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSubscriptionsUsingDataSource_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSubscriptionsUsingDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodListSubscriptionsUsingDataSource, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListSubscriptionsUsingDataSourceOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsUsingDataSourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsUsingDataSourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSubscriptionsUsingDataSourceOperationCompleted, methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted.Length.ShouldBe(1);
            methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsUsingDataSourceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsUsingDataSourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsUsingDataSourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListSubscriptionsUsingDataSourceOperationCompleted, parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted, methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted.Length.ShouldBe(1);
            methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListSubscriptionsUsingDataSourceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsUsingDataSourceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsUsingDataSourceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsUsingDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSubscriptionsUsingDataSourceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsUsingDataSourceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsUsingDataSourceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsUsingDataSourceOperationCompleted);
            var methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListSubscriptionsUsingDataSourceOperationCompleted, methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes);

            // Assert
            methodOnListSubscriptionsUsingDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSubscriptionsUsingDataSourceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSubscriptionsUsingDataSourceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSubscriptionsUsingDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSubscriptionsUsingDataSourceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListExtensions) (Return Type : Extension[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var ExtensionType = this.CreateType<ExtensionTypeEnum>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListExtensions(ExtensionType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var ExtensionType = this.CreateType<ExtensionTypeEnum>();
            var returnedValue = default(Extension[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListExtensions(ExtensionType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var ExtensionType = this.CreateType<ExtensionTypeEnum>();
            var methodListExtensionsParametersTypes = new Type[] { typeof(ExtensionTypeEnum) };
            object[] parametersOfListExtensions = { ExtensionType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListExtensions, methodListExtensionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Extension[]>(_reportingService2005InstanceFixture, parametersOfListExtensions);
            var result2 = this.GetResultOfMethod<Extension[]>(MethodListExtensions, parametersOfListExtensions, methodListExtensionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListExtensions.ShouldNotBeNull();
            parametersOfListExtensions.Length.ShouldBe(1);
            methodListExtensionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var ExtensionType = this.CreateType<ExtensionTypeEnum>();
            var methodListExtensionsParametersTypes = new Type[] { typeof(ExtensionTypeEnum) };
            object[] parametersOfListExtensions = { ExtensionType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Extension[]>(MethodListExtensions, parametersOfListExtensions, methodListExtensionsParametersTypes);

            // Assert
            parametersOfListExtensions.ShouldNotBeNull();
            parametersOfListExtensions.Length.ShouldBe(1);
            methodListExtensionsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var methodListExtensionsParametersTypes = new Type[] { typeof(ExtensionTypeEnum) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListExtensions, methodListExtensionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListExtensionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var methodListExtensionsParametersTypes = new Type[] { typeof(ExtensionTypeEnum) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListExtensions, methodListExtensionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListExtensionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var currentMethodInfo = this.GetMethodInfo(MethodListExtensions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListExtensions) (Return Type : Extension[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListExtensions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListExtensions);
            var currentMethodInfo = this.GetMethodInfo(MethodListExtensions, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListExtensionsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListExtensionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListExtensionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListExtensionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListExtensionsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListExtensionsOperationCompleted, methodOnListExtensionsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListExtensionsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListExtensionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListExtensionsOperationCompleted.Length.ShouldBe(1);
            methodOnListExtensionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListExtensionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListExtensionsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListExtensionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListExtensionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListExtensionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListExtensionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListExtensionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListExtensionsOperationCompleted, parametersOfOnListExtensionsOperationCompleted, methodOnListExtensionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListExtensionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListExtensionsOperationCompleted.Length.ShouldBe(1);
            methodOnListExtensionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListExtensionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListExtensionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListExtensionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListExtensionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListExtensionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListExtensionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListExtensionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListExtensionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListExtensionsOperationCompleted);
            var methodOnListExtensionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListExtensionsOperationCompleted, methodOnListExtensionsOperationCompletedParametersTypes);

            // Assert
            methodOnListExtensionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListExtensionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListExtensionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListExtensionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListExtensionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListEvents) (Return Type : Event[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);

            // Act
            Action executeAction = () => _reportingService2005Instance.ListEvents();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListEvents) (Return Type : Event[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);
            var returnedValue = default(Event[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListEvents();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListEvents) (Return Type : Event[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);
            Type [] methodListEventsParametersTypes = null;
            object[] parametersOfListEvents = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListEvents, methodListEventsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Event[]>(_reportingService2005InstanceFixture, parametersOfListEvents);
            var result2 = this.GetResultOfMethod<Event[]>(MethodListEvents, parametersOfListEvents, methodListEventsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListEvents.ShouldBeNull();
            methodListEventsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListEvents) (Return Type : Event[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);
            Type [] methodListEventsParametersTypes = null;
            object[] parametersOfListEvents = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Event[]>(MethodListEvents, parametersOfListEvents, methodListEventsParametersTypes);

            // Assert
            parametersOfListEvents.ShouldBeNull();
            methodListEventsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListEvents) (Return Type : Event[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);
            Type [] methodListEventsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListEvents, methodListEventsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListEventsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListEvents) (Return Type : Event[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);
            Type [] methodListEventsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListEvents, methodListEventsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListEventsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListEvents) (Return Type : Event[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListEvents_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListEvents);
            var currentMethodInfo = this.GetMethodInfo(MethodListEvents, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (OnListEventsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListEventsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListEventsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListEventsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListEventsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnListEventsOperationCompleted, methodOnListEventsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnListEventsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnListEventsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListEventsOperationCompleted.Length.ShouldBe(1);
            methodOnListEventsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListEventsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListEventsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnListEventsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListEventsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListEventsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListEventsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListEventsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListEventsOperationCompleted, parametersOfOnListEventsOperationCompleted, methodOnListEventsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListEventsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListEventsOperationCompleted.Length.ShouldBe(1);
            methodOnListEventsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListEventsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListEventsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListEventsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListEventsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListEventsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListEventsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListEventsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListEventsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListEventsOperationCompleted);
            var methodOnListEventsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListEventsOperationCompleted, methodOnListEventsOperationCompletedParametersTypes);

            // Assert
            methodOnListEventsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListEventsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListEventsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListEventsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListEventsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (FireEvent) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FireEvent_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFireEvent);
            var EventType = this.CreateType<string>();
            var EventData = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.FireEvent(EventType, EventData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FireEvent) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FireEvent_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFireEvent);
            var EventType = this.CreateType<string>();
            var EventData = this.CreateType<string>();
            var methodFireEventParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfFireEvent = { EventType, EventData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFireEvent, methodFireEventParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfFireEvent);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFireEvent.ShouldNotBeNull();
            parametersOfFireEvent.Length.ShouldBe(2);
            methodFireEventParametersTypes.Length.ShouldBe(2);
            methodFireEventParametersTypes.Length.ShouldBe(parametersOfFireEvent.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FireEvent) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FireEvent_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFireEvent);
            var EventType = this.CreateType<string>();
            var EventData = this.CreateType<string>();
            var methodFireEventParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfFireEvent = { EventType, EventData };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFireEvent, parametersOfFireEvent, methodFireEventParametersTypes);

            // Assert
            parametersOfFireEvent.ShouldNotBeNull();
            parametersOfFireEvent.Length.ShouldBe(2);
            methodFireEventParametersTypes.Length.ShouldBe(2);
            methodFireEventParametersTypes.Length.ShouldBe(parametersOfFireEvent.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FireEvent) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FireEvent_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFireEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodFireEvent, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FireEvent) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FireEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFireEvent);
            var methodFireEventParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFireEvent, methodFireEventParametersTypes);

            // Assert
            methodFireEventParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FireEvent) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FireEvent_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFireEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodFireEvent, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnFireEventOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFireEventOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFireEventOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnFireEventOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnFireEventOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnFireEventOperationCompleted, methodOnFireEventOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfOnFireEventOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnFireEventOperationCompleted.ShouldNotBeNull();
            parametersOfOnFireEventOperationCompleted.Length.ShouldBe(1);
            methodOnFireEventOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnFireEventOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnFireEventOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnFireEventOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFireEventOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFireEventOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnFireEventOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnFireEventOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnFireEventOperationCompleted, parametersOfOnFireEventOperationCompleted, methodOnFireEventOperationCompletedParametersTypes);

            // Assert
            parametersOfOnFireEventOperationCompleted.ShouldNotBeNull();
            parametersOfOnFireEventOperationCompleted.Length.ShouldBe(1);
            methodOnFireEventOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnFireEventOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnFireEventOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnFireEventOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFireEventOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFireEventOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnFireEventOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnFireEventOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFireEventOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFireEventOperationCompleted);
            var methodOnFireEventOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnFireEventOperationCompleted, methodOnFireEventOperationCompletedParametersTypes);

            // Assert
            methodOnFireEventOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnFireEventOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFireEventOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFireEventOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnFireEventOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListTasks) (Return Type : Task[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListTasks(SecurityScope);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListTasks) (Return Type : Task[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();
            var returnedValue = default(Task[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListTasks(SecurityScope);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}