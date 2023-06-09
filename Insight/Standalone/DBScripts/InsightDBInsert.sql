GO
INSERT [dbo].[SERVERS] ([GUID], [NAME], [SERVER_TYPE], [SOLR_CORE_NAME], [API_URL], [UI_URL], [IS_DEFAULT_SOLR_SERVER], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'Insight', N'SOLR_STANDALONE', N'insight', N'http://localhost:8983/solr', N'http://localhost:8983/solr', N'Y', CAST(N'2016-09-16 12:33:55.493' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:55.493' AS DateTime), N'unknown')
INSERT [dbo].[SERVERS] ([GUID], [NAME], [SERVER_TYPE], [SOLR_CORE_NAME], [API_URL], [UI_URL], [IS_DEFAULT_SOLR_SERVER], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'6af7b76c-1676-11e6-96e0-fdfa68fbc9ad', N'ManifoldServer', N'MANIFOLD', NULL, N'http://localhost:8345', N'http://localhost:8345/mcf-crawler-ui', N'N', CAST(N'2016-09-16 12:33:55.497' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:55.497' AS DateTime), N'unknown')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'21b41bc2-12ae-11e6-a27d-efbc763acfa3', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Service Incident', N'N', N'select * from incident_service_insight_meta_data_query_view', N'select * from incident_service_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${field_secondary_id!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Status</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_status_desc!?url(''utf-8'')!}" >${xfield_status_desc!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Customer</font></div>
  <div class="Field3Value"><font color="#6d6e70">${xfield_customer_name!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="#6d6e70">Id:</font></th><td><font color="#6d6e70">${field_secondary_id!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To:</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
  <tr><th><font color="#6d6e70">Type:</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Priority:</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status:</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Source:</font></th><td><font color="#6d6e70">${xfield_source_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tags:</font></th><td><font color="#6d6e70">${field_tags!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tracking Description:</font></th><td><font color="#6d6e70">${field_trackingDesc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code1:</font></th><td><font color="#6d6e70">${field_resolutionDesc1!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code2:</font></th><td><font color="#6d6e70">${field_resolutionDesc2!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code3:</font></th><td><font color="#6d6e70">${field_resolutionDesc3!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code4:</font></th><td><font color="#6d6e70">${field_resolutionDesc4!}</font></td></tr>
</table>', N'66ba2cf6-fa46-11e5-b70e-2b085493ecb8', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.500' AS DateTime), N'unknown', CAST(N'2016-10-17 12:28:58.253' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'3d14d11e-12af-11e6-a27d-c94d0e1da884', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Service Tasks', N'N', N'select * from task_service_insight_meta_data_query_view', N'select * from task_service_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${xfield_customerName!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Type</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_type_desc!?url(''utf-8'')!}" >${xfield_type_desc!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Incident Id</font></div>
  <div class="Field3Value"><font color="#6d6e70">${field_ownerSecondaryId!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="#6d6e70">Task Id</font></th><td><font color="#6d6e70">${attr_secondary_id!}</font></td></tr>
    <tr><th><font color="#6d6e70">Type</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
  <tr><th><font color="#6d6e70">Priority</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tags</font></th><td><font color="#6d6e70">${field_tags!}</font></td></tr>
    <tr><th><font color="#6d6e70">UpdateDate</font></th><td><font color="#6d6e70">${attr_last_modified!}</font></td></tr>
    <tr><th><font color="#6d6e70">RecallDate</font></th><td><font color="#6d6e70">${attr_recallDateTime!}</font></td></tr>
    <tr><th><font color="#6d6e70">Customer</font></th><td><font color="#6d6e70">${xfield_customerName!}</font></td></tr>
    <tr><th><font color="#6d6e70">IncidentId</font></th><td><font color="#6d6e70">${field_ownerSecondaryId!}</font></td></tr>
</table>', N'9ea3aec9-fa46-11e5-b70e-0f1912cc9f37', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.503' AS DateTime), N'unknown', CAST(N'2016-10-17 12:31:55.067' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'5b88c22b-12ad-11e6-a27d-655eda8a65b0', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Sale Opportunity', N'N', N'select * from incident_sales_insight_meta_data_query_view', N'select * from incident_sales_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${field_secondary_id!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Status</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_status_desc!?url(''utf-8'')!}" >${xfield_status_desc!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Customer</font></div>
  <div class="Field3Value"><font color="#6d6e70">${xfield_customer_name!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="#6d6e70">Id:</font></th><td><font color="#6d6e70">${field_secondary_id!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To:</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
  <tr><th><font color="#6d6e70">Type:</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Priority:</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status:</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Source:</font></th><td><font color="#6d6e70">${xfield_source_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tags:</font></th><td><font color="#6d6e70">${field_tags!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tracking Description:</font></th><td><font color="#6d6e70">${field_trackingDesc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code1:</font></th><td><font color="#6d6e70">${field_resolutionDesc1!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code2:</font></th><td><font color="#6d6e70">${field_resolutionDesc2!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code3:</font></th><td><font color="#6d6e70">${field_resolutionDesc3!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code4:</font></th><td><font color="#6d6e70">${field_resolutionDesc4!}</font></td></tr>
</table>', N'56137af5-fa46-11e5-b70e-61a8b482608e', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.507' AS DateTime), N'unknown', CAST(N'2016-10-17 12:27:30.783' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'5e492445-12ae-11e6-a27d-4b3231e06a5c', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Individual', N'N', N'select * from individual_insight_meta_data_query_view', N'select * from individual_insight_data_query_view
Where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><a style="color:#6d6e70" href="#Insight/search/${field_secondary_id!?url(''utf-8'')!}" >${field_secondary_id!}</a></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Email</font></div>
  <div class="Field2Value"><a href="mailto:${attr_email_address!}" style="color:#6d6e70">${attr_email_address!}</a></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Country</font></div>
  <div class="Field3Value"><font color="#6d6e70"><a style="text-decoration:none; color:#6d6e70" href="#Insight/search/${field_country_desc!?url(''utf-8'')!}" >${field_country_desc!}</a></font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="6d6e70">Id: </font></th><td><font color="6d6e70">${field_secondary_id!}</font></td></tr>
  <tr><th><font color="6d6e70">Company Name: </font></th><td><font color="6d6e70">${xfield_company_name!}</font></td></tr>
  <tr><th><font color="6d6e70">Address: </font></th><td><font color="6d6e70">${xfield_address1!}</font></td></tr>
    <tr><th></th><td><font color="6d6e70">${attr_prod_location!}, ${xfield_post_code!}</font></td></tr>
    <tr><th><font color="6d6e70">State: </font></th><td><font color="6d6e70">${field_region_name!}</font></td></tr>
    <tr><th><font color="6d6e70">Country: </font></th><td><font color="6d6e70">${field_country_desc!}</font></td></tr>
    <tr><th><font color="6d6e70">Status: </font></th><td><font color="6d6e70">${xfield_status_desc!}</font></td></tr>
    <tr><th><font color="6d6e70">Type: </font></th><td><font color="6d6e70">${xfield_type_desc!}</font></td></tr>
    <tr><th><font color="6d6e70">SubType: </font></th><td><font color="6d6e70">${xfield_subtype_desc!}</font></td></tr>
    <tr><th><font color="6d6e70">${field_email_desc!}: </font></th><td><font color="6d6e70">${attr_email_address!}</font></td></tr>
  <tr><th><font color="6d6e70">${attr_phone_type_desc!}: </font></th><td><font color="6d6e70">${attr_phone_number_masked!}</font></td></tr>
</table>', N'07f353e4-fa46-11e5-b70e-c534f083c0c6', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.510' AS DateTime), N'unknown', CAST(N'2016-09-21 15:43:54.733' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'7e294741-12af-11e6-a27d-533ffb6b03cd', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Support Tasks', N'N', N'select * from task_support_insight_meta_data_query_view', N'select * from task_support_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${xfield_customerName!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Type</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_type_desc!?url(''utf-8'')!}" >${xfield_type_desc!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Incident Id</font></div>
  <div class="Field3Value"><font color="#6d6e70">${field_ownerSecondaryId!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="#6d6e70">Task Id</font></th><td><font color="#6d6e70">${attr_secondary_id!}</font></td></tr>
    <tr><th><font color="#6d6e70">Type</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
  <tr><th><font color="#6d6e70">Priority</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tags</font></th><td><font color="#6d6e70">${field_tags!}</font></td></tr>
    <tr><th><font color="#6d6e70">UpdateDate</font></th><td><font color="#6d6e70">${attr_last_modified!}</font></td></tr>
    <tr><th><font color="#6d6e70">RecallDate</font></th><td><font color="#6d6e70">${attr_recallDateTime!}</font></td></tr>
    <tr><th><font color="#6d6e70">Customer</font></th><td><font color="#6d6e70">${xfield_customerName!}</font></td></tr>
    <tr><th><font color="#6d6e70">IncidentId</font></th><td><font color="#6d6e70">${field_ownerSecondaryId!}</font></td></tr>
</table>', N'be0dd3da-fa46-11e5-b70e-679bfc454fe8', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.513' AS DateTime), N'unknown', CAST(N'2016-10-17 12:32:29.337' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'82c7dde5-12ac-11e6-a27d-8b28e00f9dce', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Company', N'N', N'select * from company_insight_meta_data_query_view', N'select * from company_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${field_secondary_id!?url(''utf-8'')!}" >${field_secondary_id!}</a></font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">URL</font></div>
  <div class="Field2Value"><a href="http://${field_url!}" target="blank" style="color:#6d6e70">${field_url!}</a></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Country</font></div>
  <div class="Field3Value"><font color="#6d6e70"><a style="text-decoration:none; color:#6d6e70" href="#Insight/search/${field_country_desc!?url(''utf-8'')!}" >${field_country_desc!}</a></font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
<tr><th><font color="#6d6e70">Company Name:</font></th><td><font color="#6d6e70">${field_company_name!}</font></td></tr>
<tr><th><font color="#6d6e70">ID:</font></th><td><font color="#6d6e70">${field_secondary_id!}</font></td></tr>
<tr><th><font color="#6d6e70">Address:</font></th><td><font color="#6d6e70">${field_address1!}</font></td></tr>
<tr><th></th><td><font color="#6d6e70">${attr_prod_location!}, ${field_post_code!}</font></td></tr>
<tr><th><font color="#6d6e70">State:</font></th><td><font color="#6d6e70">${field_region_name!}</font></td></tr>
<tr><th><font color="#6d6e70">Country:</font></th><td><font color="#6d6e70">${field_country_desc!}</font></td></tr>
<tr><th><font color="#6d6e70">URL:</font></th><td><font color="#6d6e70">${field_url!}</font></td></tr>
<tr><th><font color="#6d6e70">Source:</font></th><td><font color="#6d6e70">${xfield_source!}</font></td></tr>
<tr><th><font color="#6d6e70">Type:</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
<tr><th><font color="#6d6e70">Subtype:</font></th><td><font color="#6d6e70">${field_subtype_desc!}</font></td></tr>
<tr><th><font color="#6d6e70">Market Sector:</font></th><td><font color="#6d6e70">${xfield_marketSector!}</font></td></tr>
<tr><th><font color="#6d6e70">${field_email_desc!}:</font></th><td><font color="#6d6e70">${field_email_address!}</font></td></tr>
<tr><th><font color="#6d6e70">${field_phone_type_desc!}:</font></th><td><font color="#6d6e70">${attr_phone_number_masked!}</font></td></tr>
    
</table>', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.517' AS DateTime), N'unknown', CAST(N'2016-10-17 11:50:59.290' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'b2e0b868-12ae-11e6-a27d-31e52b5b73c3', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Support Operations', N'N', N'select * from incident_support_insight_meta_data_query_view', N'select * from incident_support_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${field_secondary_id!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Status</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_status_desc!?url(''utf-8'')!}" >${xfield_status_desc!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Customer</font></div>
  <div class="Field3Value"><font color="#6d6e70">${xfield_customer_name!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="#6d6e70">Id:</font></th><td><font color="#6d6e70">${field_secondary_id!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To:</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
  <tr><th><font color="#6d6e70">Type:</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Priority:</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status:</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Source:</font></th><td><font color="#6d6e70">${xfield_source_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tags:</font></th><td><font color="#6d6e70">${field_tags!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tracking Description:</font></th><td><font color="#6d6e70">${field_trackingDesc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code1:</font></th><td><font color="#6d6e70">${field_resolutionDesc1!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code2:</font></th><td><font color="#6d6e70">${field_resolutionDesc2!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code3:</font></th><td><font color="#6d6e70">${field_resolutionDesc3!}</font></td></tr>
    <tr><th><font color="#6d6e70">Resolution Code4:</font></th><td><font color="#6d6e70">${field_resolutionDesc4!}</font></td></tr>
</table>', N'74200bd7-fa46-11e5-b70e-5fbafc3eba8f', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.520' AS DateTime), N'unknown', CAST(N'2016-10-17 12:29:08.237' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'e8d6c50f-12ad-11e6-a27d-dfc3e89632ed', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Email', N'N', N'select * from email_insight_meta_data_query_view', N'select * from email_insight_data_query_view  
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${attr_secondary_id!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Sent By</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="mailto:${xfield_form_email_address!}" >${xfield_form_email_address!!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field2Header"><font color="#6d6e70">Sent On</font></div>
  <div class="Field2Value"><font color="#6d6e70">${field_sent_date!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
    <tr><th><font color="#6d6e70">Follow Up: </font></th><td><font color="#6d6e70">${field_followup!}</font></td></tr>
    <tr><th><font color="#6d6e70">	Sent: </font></th><td><font color="#6d6e70">${field_sent!}</font></td></tr>
    <tr><th><font color="#6d6e70">From: </font></th><td><font color="#6d6e70">	${xfield_display_name!}</font></td></tr>
    <tr><th style="vertical-align:top;"><font color="#6d6e70">	To: </font></th><td><font color="#6d6e70">	${xfield_update_by!}</font></td>
    </tr> 
    <tr><th><font color="#6d6e70">	Date: </font></th><td><font color="#6d6e70">${field_sent_date!}</font></td></tr>
</table>', N'e021e33c-fa46-11e5-b70e-5bc6f72d9544', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.520' AS DateTime), N'unknown', CAST(N'2016-10-17 12:07:43.753' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'f5691cb8-12ac-11e6-a27d-c528d2c53020', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'WorkTicket', N'N', N'select * from workticket_insight_meta_data_query_view', N'select * from workticket_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${attr_secondary_id!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Assigned To</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_user_name!?url(''utf-8'')!}" >${xfield_user_name!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Status</font></div>
  <div class="Field3Value"><font color="#6d6e70"><a style="color:#5D5A59" href="#Insight/search/${xfield_status_desc!?url(''utf-8'')!}" >${xfield_status_desc!}</a></font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
    <tr><th><font color="#6d6e70">Id:</font></th><td><font color="#6d6e70">${attr_secondary_id!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To:</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
  <tr><th><font color="#6d6e70">Product:</font></th><td><font color="#6d6e70">${xfield_description1!}</font></td></tr>
  <tr><th><font color="#6d6e70">Source:</font></th><td><font color="#6d6e70">${xfield_source_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status:</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Priority:</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Severity:</font></th><td><font color="#6d6e70">${xfield_severity_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Version Found:</font></th><td><font color="#6d6e70">${field_versionFound!}</font></td></tr>
    <tr><th><font color="#6d6e70">Version Fixed:</font></th><td><font color="#6d6e70">${field_versionFixed!}</font></td></tr>
    <tr><th><font color="#6d6e70">Version Shipped:</font></th><td><font color="#6d6e70">${field_versionShipped!}</font></td></tr>
</table>', N'd02553eb-fa46-11e5-b70e-15762f087056', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.523' AS DateTime), N'unknown', CAST(N'2016-10-17 12:48:17.467' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[DATA_DEFINITIONS] ([GUID], [SOLR_SERVER_GUID], [DATASOURCE_JNDI], [IS_ENABLED], [DESCRIPTION], [IS_BINARY], [METADATA_QUERY], [DATA_QUERY], [URL_PATTERN], [PERMISSION_QUERY], [PERMISSION_FIELD], [SYNC_INTERVAL], [FAILURE_THRESHOLD], [SUMMARY_TEMPLATE], [DETAIL_TEMPLATE], [DOCTYPE_GUID], [CRAWLER_TYPE], [LDAP_FILTER], [LDAP_ROOT], [LDAP_SEARCH_BASE], [LDAP_USERNAME], [LDAP_PASSWORD], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [SYNC_INTERVAL_TYPE]) VALUES (N'faa9a49b-12ae-11e6-a27d-8d615e6a6069', N'1d6ef11d-fa47-11e5-b70e-0b27556a8f72', N'java:jboss/datasources/OnyxDS', N'Y', N'Sales Tasks', N'N', N'select * from task_sales_insight_meta_data_query_view', N'select * from task_sales_insight_data_query_view
where search_external_id in ({IDS})', N'', N'', N'', CAST(20 AS Numeric(11, 0)), CAST(10 AS Numeric(2, 0)), N'<div class="Field1"><font color="#6d6e70">${xfield_customerName!}</font></div>
<div class="SummaryCell1">
  <div class="Field2Header"><font color="#6d6e70">Type</font></div>
  <div class="Field2Value"><font color="#6d6e70"><a style="color:#6d6e70" href="#Insight/search/${xfield_type_desc!?url(''utf-8'')!}" >${xfield_type_desc!}</a></font></div>
</div>
<div class="SummaryCell2">
  <div class="Field3Header"><font color="#6d6e70">Incident Id</font></div>
  <div class="Field3Value"><font color="#6d6e70">${field_ownerSecondaryId!}</font></div>
</div>
<div class="relevancy">
  <div class="relevancyScore"><font color="#438fbc">Relevance hit:</font></div>
  <div class="relevancyPercentage"><font color="#438fbc">${result.normalizedScore}%</font></div>
</div>', N'<table class="detailTable">
  <tr><th><font color="#6d6e70">Task Id</font></th><td><font color="#6d6e70">${attr_secondary_id!}</font></td></tr>
    <tr><th><font color="#6d6e70">Type</font></th><td><font color="#6d6e70">${xfield_type_desc!}</font></td></tr>
  <tr><th><font color="#6d6e70">Assigned To</font></th><td><font color="#6d6e70">${xfield_user_name!}</font></td></tr>
    <tr><th><font color="#6d6e70">Status</font></th><td><font color="#6d6e70">${xfield_status_desc!}</font></td></tr>
  <tr><th><font color="#6d6e70">Priority</font></th><td><font color="#6d6e70">${xfield_priority_desc!}</font></td></tr>
    <tr><th><font color="#6d6e70">Tags</font></th><td><font color="#6d6e70">${field_tags!}</font></td></tr>
    <tr><th><font color="#6d6e70">UpdateDate</font></th><td><font color="#6d6e70">${attr_last_modified!}</font></td></tr>
    <tr><th><font color="#6d6e70">RecallDate</font></th><td><font color="#6d6e70">${attr_recallDateTime!}</font></td></tr>
    <tr><th><font color="#6d6e70">Customer</font></th><td><font color="#6d6e70">${xfield_customerName!}</font></td></tr>
    <tr><th><font color="#6d6e70">IncidentId</font></th><td><font color="#6d6e70">${field_ownerSecondaryId!}</font></td></tr>
</table>', N'90c592a8-fa46-11e5-b70e-df2c59fceb53', N'DATABASE', NULL, NULL, NULL, NULL, NULL, CAST(N'2016-09-16 12:33:55.523' AS DateTime), N'unknown', CAST(N'2016-10-17 12:31:17.377' AS DateTime), N'sa', N'MINUTES')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'003bb125-fc85-11e5-a5bc-836e5c75c996', N'SQL', N'All Support Operations', N'All Support Operations', N'N', N'select * from incident_support_all_insight_lv_view
where owner_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'support', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ID</th>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row">${rec.secondary_id!}</td>
    <td class = "lvtable-row">${rec.desc1!}</td>
    <td class = "lvtable-row">${rec.user_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>', N'Y', CAST(6 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.530' AS DateTime), N'unknown', CAST(N'2016-10-14 11:56:05.803' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'0ac62ad7-fc84-11e5-a5bc-132e7eb171d7', N'SQL', N'All Tasks', N'All Tasks', N'N', N'select * from task_all_insight_lv_view
where tOwner= ''${attr_primary_id}'' Or incOwner= ''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'tasks', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">STATUS</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row ">${rec.desc1!}</td>
    <td class = "lvtable-row ">${rec.xfield_staus_desc!}</td>
    <td class = "lvtable-row ">${rec.xfield_assigned_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>
', N'Y', CAST(7 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.537' AS DateTime), N'unknown', CAST(N'2016-10-14 12:34:54.990' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'0bd2bc1b-fc88-11e5-a5bc-b1ccb3d76482', N'SQL', N'Open Service Incidents', N'Open Service Incidents', N'N', N'select * from incident_service_open_insight_lv_view
where owner_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'service', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ID</th>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row ">${rec.secondary_id!}</td>
    <td class = "lvtable-row ">${rec.desc1!}</td>
    <td class = "lvtable-row ">${rec.user_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>
', N'Y', CAST(3 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.560' AS DateTime), N'unknown', CAST(N'2016-10-14 13:16:37.053' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'49bcf462-fc88-11e5-a5bc-05092171fb8d', N'SQL', N'Open Support Operations', N'Open Support Operations', N'N', N'select * from incident_support_open_insight_lv_view
where owner_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'support', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ID</th>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row ">${rec.secondary_id!}</td>
    <td class = "lvtable-row ">${rec.desc1!}</td>
    <td class = "lvtable-row ">${rec.user_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>
', N'Y', CAST(5 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.567' AS DateTime), N'unknown', CAST(N'2016-10-14 13:18:34.893' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'548800dd-fc84-11e5-a5bc-b518b8be3964', N'SQL', N'All Sales Opportunity', N'All Sales Opportunity', N'N', N'select * from incident_sales_all_insight_lv_view where owner_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'sales', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ID</th>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row ">${rec.secondary_id!}</td>
    <td class = "lvtable-row ">${rec.desc1!}</td>
    <td class = "lvtable-row ">${rec.user_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>
', N'Y', CAST(2 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.570' AS DateTime), N'unknown', CAST(N'2016-10-14 13:21:01.267' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'SQL', N'Last 3 Comments', N'Last 3 Comments', N'N', N'SELECT TOP 3 * from comments_last_three_insight_lv_view where cmtOwner =''${attr_primary_id}'' order by entry_date desc', N'java:jboss/datasources/OnyxDS', N'comments', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ENTERED BY</th>
    <th class = "lvtable-header">ENTRY DATE</th>
    <th class = "lvtable-header">WORKNOTES</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row">${rec.user_name!}</td>
    <td class = "lvtable-row">${rec.entry_date!}</td>
    <td class = "lvtable-row">${rec.work_note_text!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>', N'Y', CAST(9 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.577' AS DateTime), N'unknown', CAST(N'2016-10-14 13:19:17.537' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'b0fde510-fc84-11e5-a5bc-9f485212145d', N'SQL', N'All Service Incidents', N'All Service Incidents', N'N', N'select * from incident_service_all_insight_lv_view
where owner_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'services', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ID</th>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row">${rec.secondary_id!}</td>
    <td class = "lvtable-row">${rec.desc1!}</td>
    <td class = "lvtable-row">${rec.user_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>', N'Y', CAST(4 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.583' AS DateTime), N'unknown', CAST(N'2016-10-14 11:53:56.313' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'b698d81d-fc88-11e5-a5bc-d5d46a3e2d2f', N'SQL', N'External Contacts', N'External Contacts', N'N', N'select * from external_contacts_insight_lv_view
where contact_for_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'contacts', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">CONTACT TYPE</th>
    <th class = "lvtable-header">CONTACT NAME</th>
    <th class = "lvtable-header">EMAIL</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row">${rec.contact_type_desc!}</td>
    <td class = "lvtable-row">${rec.xfield_excontact_name!}</td>
    <td class = "lvtable-row">${rec.email_address!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>', N'Y', CAST(8 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.590' AS DateTime), N'unknown', CAST(N'2016-10-14 13:20:40.203' AS DateTime), N'sa')
INSERT [dbo].[LIVE_VIEWS] ([GUID], [QUERY_TYPE], [NAME], [DISPLAY_NAME], [IS_BINARY], [DATA_QUERY], [DATASOURCE_JNDI], [QUERY_PATTERN], [TEMPLATE], [IS_ENABLED], [ORDINAL], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'c05d1b98-fc87-11e5-a5bc-dd70ad9d14c1', N'SQL', N'Open Sales Opportunity', N'Open Sales Opportunity', N'N', N'select * from incident_sales_open_insight_lv_view
where owner_id=''${attr_primary_id}''', N'java:jboss/datasources/OnyxDS', N'sales', N'<#list records>
<table class = "lvtable">
  <tr>
    <th class = "lvtable-header">ID</th>
    <th class = "lvtable-header">DESCRIPTION</th>
    <th class = "lvtable-header">ASSIGNED TO</th>
  </tr>
<#items as rec>
  <tr>
    <td class = "lvtable-row ">${rec.secondary_id!}</td>
    <td class = "lvtable-row ">${rec.desc1!}</td>
    <td class = "lvtable-row ">${rec.user_name!}</td>
  </tr>
  </#items>
  <#else>
    None.
</table>
</#list>
', N'Y', CAST(1 AS Numeric(11, 0)), CAST(N'2016-09-16 12:33:55.600' AS DateTime), N'unknown', CAST(N'2016-10-14 13:11:14.800' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'07f353e4-fa46-11e5-b70e-c534f083c0c6', N'Individual', N'icon-businessperson2', CAST(2 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.477' AS DateTime), N'unknown', CAST(N'2016-09-21 15:12:47.453' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'56137af5-fa46-11e5-b70e-61a8b482608e', N'Sales Opportunity', N'icon-revenue', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.480' AS DateTime), N'unknown', CAST(N'2016-10-14 13:42:50.600' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'66ba2cf6-fa46-11e5-b70e-2b085493ecb8', N'Service Incidents', N'icon-bell', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.483' AS DateTime), N'unknown', CAST(N'2016-10-14 13:43:07.740' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'74200bd7-fa46-11e5-b70e-5fbafc3eba8f', N'Support Operations', N'icon-user-earth', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.483' AS DateTime), N'unknown', CAST(N'2016-10-14 13:43:41.403' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'90c592a8-fa46-11e5-b70e-df2c59fceb53', N'Sales Tasks', N'icon-cash-flow', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.487' AS DateTime), N'unknown', CAST(N'2016-10-14 13:42:58.253' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'9ea3aec9-fa46-11e5-b70e-0f1912cc9f37', N'Service Tasks', N'icon-megaphone', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.487' AS DateTime), N'unknown', CAST(N'2016-10-14 13:43:20.457' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'be0dd3da-fa46-11e5-b70e-679bfc454fe8', N'Support Tasks', N'icon-box-software', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.487' AS DateTime), N'unknown', CAST(N'2016-10-14 13:43:54.360' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'd02553eb-fa46-11e5-b70e-15762f087056', N'WorkTickets', N'icon-clipboard-check-edit', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.490' AS DateTime), N'unknown', CAST(N'2016-10-14 13:44:07.657' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'e021e33c-fa46-11e5-b70e-5bc6f72d9544', N'Emails', N'icon-mail', CAST(0 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.490' AS DateTime), N'unknown', CAST(N'2016-10-14 13:42:40.077' AS DateTime), N'sa')
INSERT [dbo].[DOCTYPES] ([GUID], [DISPLAY_NAME], [DISPLAY_ICON], [TAB_PRIORITY], [BACKGROUND_COLOR], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'e605b843-fa45-11e5-b70e-d5c5f14d6d72', N'Company', N'icon-office-building2', CAST(1 AS Numeric(11, 0)), N'438fbc', CAST(N'2016-09-16 12:33:55.490' AS DateTime), N'unknown', CAST(N'2016-10-14 13:42:26.560' AS DateTime), N'sa')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'2fee7fe0-9205-11e6-817c-2d12239fe908', N'003bb125-fc85-11e5-a5bc-836e5c75c996', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'2feea6f1-9205-11e6-817c-a7d0218a528a', N'003bb125-fc85-11e5-a5bc-836e5c75c996', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'6f955b62-9210-11e6-b07b-2fa12528b480', N'0bd2bc1b-fc88-11e5-a5bc-b1ccb3d76482', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'6f958273-9210-11e6-b07b-4187c26bc6d5', N'0bd2bc1b-fc88-11e5-a5bc-b1ccb3d76482', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3cf787-9210-11e6-b07b-25894e0e9962', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'56137af5-fa46-11e5-b70e-61a8b482608e')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3d1e98-9210-11e6-b07b-7fb3c18ce945', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'66ba2cf6-fa46-11e5-b70e-2b085493ecb8')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3d6cb9-9210-11e6-b07b-5101a24fd508', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'74200bd7-fa46-11e5-b70e-5fbafc3eba8f')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3dbada-9210-11e6-b07b-0d684e09419a', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'90c592a8-fa46-11e5-b70e-df2c59fceb53')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3e08fb-9210-11e6-b07b-2f8080769fe5', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'9ea3aec9-fa46-11e5-b70e-0f1912cc9f37')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'0d110fc1-9211-11e6-b07b-191c6b37beb1', N'548800dd-fc84-11e5-a5bc-b518b8be3964', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'0d1136d2-9211-11e6-b07b-13a48b7be2ab', N'548800dd-fc84-11e5-a5bc-b518b8be3964', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3e300c-9210-11e6-b07b-073dc3adda60', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'be0dd3da-fa46-11e5-b70e-679bfc454fe8')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'cf3e571d-9210-11e6-b07b-81d0c56a2be1', N'79c87445-fc88-11e5-a5bc-c14aeb245763', N'd02553eb-fa46-11e5-b70e-15762f087056')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'e2c080fe-9204-11e6-817c-8f74b86ca50e', N'b0fde510-fc84-11e5-a5bc-9f485212145d', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'e2c0a80f-9204-11e6-817c-9d316795ec53', N'b0fde510-fc84-11e5-a5bc-9f485212145d', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'9c3cb042-920a-11e6-b07b-692b657fa351', N'0ac62ad7-fc84-11e5-a5bc-132e7eb171d7', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'9c3cfe63-920a-11e6-b07b-2f306bf01479', N'0ac62ad7-fc84-11e5-a5bc-132e7eb171d7', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'9c3d4c84-920a-11e6-b07b-17a179f6b335', N'0ac62ad7-fc84-11e5-a5bc-132e7eb171d7', N'56137af5-fa46-11e5-b70e-61a8b482608e')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'9c3d7395-920a-11e6-b07b-fd4eb3ce00f0', N'0ac62ad7-fc84-11e5-a5bc-132e7eb171d7', N'66ba2cf6-fa46-11e5-b70e-2b085493ecb8')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'9c3d9aa6-920a-11e6-b07b-bb70b557d7d2', N'0ac62ad7-fc84-11e5-a5bc-132e7eb171d7', N'74200bd7-fa46-11e5-b70e-5fbafc3eba8f')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'0083b68f-9211-11e6-b07b-ede71b46be8c', N'b698d81d-fc88-11e5-a5bc-d5d46a3e2d2f', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'008404b0-9211-11e6-b07b-3920d03b26cd', N'b698d81d-fc88-11e5-a5bc-d5d46a3e2d2f', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'af82ac0f-920f-11e6-b07b-7ba215d977fc', N'c05d1b98-fc87-11e5-a5bc-dd70ad9d14c1', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'af82d320-920f-11e6-b07b-3b49973b4a6c', N'c05d1b98-fc87-11e5-a5bc-dd70ad9d14c1', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'b5d22955-9210-11e6-b07b-353289335b05', N'49bcf462-fc88-11e5-a5bc-05092171fb8d', N'07f353e4-fa46-11e5-b70e-c534f083c0c6')
INSERT [dbo].[LIVEVIEW_DOCTYPES] ([GUID], [LIVEVIEW_GUID], [DOCTYPE_GUID]) VALUES (N'b5d29e86-9210-11e6-b07b-2dcdbf0a0c6b', N'49bcf462-fc88-11e5-a5bc-05092171fb8d', N'e605b843-fa45-11e5-b70e-d5c5f14d6d72')
INSERT [dbo].[ACTIONS] ([GUID], [NAME], [DISPLAY_NAME], [DISPLAY_ICON], [ACTION_TYPE], [URL_TEMPLATE], [ORDINAL], [IS_ENABLED], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY]) VALUES (N'e8e122ed-74da-11e6-b3cf-ffe4b788d572', N'Google', N'Google', N'icon-compass', N'HYPERLINK', N'http://www.google.co.in', CAST(0 AS Numeric(11, 0)), N'Y', CAST(N'2016-09-16 12:33:55.617' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:55.617' AS DateTime), N'unknown')
INSERT [dbo].[SYSTEM_PREFS] ([GUID], [NAME], [I18N_DISPLAY_KEY], [VALUE], [PREF_TYPE], [OVERRIDE_TYPE], [IS_CACHEABLE], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [MIN_VALUE], [MAX_VALUE]) VALUES (N'00000000-1010-42d1-b2f5-4e5a4dcd0001', N'Supported Locales', N'supported_locales', N'en_US', N'STRING', N'NOT_OVERRIDABLE', N'Y', CAST(N'2016-09-16 12:33:54.697' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:54.703' AS DateTime), N'unknown', NULL, NULL)
INSERT [dbo].[SYSTEM_PREFS] ([GUID], [NAME], [I18N_DISPLAY_KEY], [VALUE], [PREF_TYPE], [OVERRIDE_TYPE], [IS_CACHEABLE], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [MIN_VALUE], [MAX_VALUE]) VALUES (N'00000000-1010-42d1-b2f5-4e5a4dcd0002', N'Company Name', N'company_name', N'Insight', N'STRING', N'NOT_OVERRIDABLE', N'Y', CAST(N'2016-09-16 12:33:54.697' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:54.703' AS DateTime), N'unknown', NULL, NULL)
INSERT [dbo].[SYSTEM_PREFS] ([GUID], [NAME], [I18N_DISPLAY_KEY], [VALUE], [PREF_TYPE], [OVERRIDE_TYPE], [IS_CACHEABLE], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [MIN_VALUE], [MAX_VALUE]) VALUES (N'00000000-1010-42d1-b2f5-4e5a4dcd0003', N'Company Logo', N'company_logo', N'extensions/Insight_Logo.png', N'STRING', N'NOT_OVERRIDABLE', N'Y', CAST(N'2016-09-16 12:33:54.697' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:54.703' AS DateTime), N'unknown', NULL, NULL)
INSERT [dbo].[SYSTEM_PREFS] ([GUID], [NAME], [I18N_DISPLAY_KEY], [VALUE], [PREF_TYPE], [OVERRIDE_TYPE], [IS_CACHEABLE], [CREATED], [CREATED_BY], [MODIFIED], [MODIFIED_BY], [MIN_VALUE], [MAX_VALUE]) VALUES (N'00000000-1010-42d1-b2f5-4e5a4dcd0004', N'Search Results Pane', N'search_result_width', N'60', N'INTEGER', N'NOT_OVERRIDABLE', N'Y', CAST(N'2016-09-16 12:33:54.770' AS DateTime), N'unknown', CAST(N'2016-09-16 12:33:54.770' AS DateTime), N'unknown', 30, 70)
