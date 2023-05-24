/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_ticket_audit_log_rs_view' AND type = N'v')
DROP VIEW work_ticket_audit_log_rs_view
GO 
create view work_ticket_audit_log_rs_view
as	
	select a.work_ticket_audit_log_id,
           a.work_ticket_id,
           a.site_id,
	       l.language_code,
           a.secondary_id,
           a.work_ticket_product_code,
           a.description,
           a.type_did,
           a.source_did,
           a.status_did,
           a.priority_did,
           a.severity_did,
           a.found_date,
           a.expected_fix_date,
           a.fixed_date,
           a.shipped_date,
           a.version_found,
           a.version_fixed,
           a.version_shipped,
           a.resolution_did1,
           a.resolution_did2,
           a.resolution_did3,
           a.resolution_did4,
           a.total_time,
           a.total_labor,
           a.time,
           a.labor,
           a.assigned_to,
           a.read_only_access,
           a.private_access,
           a.insert_by,
           a.insert_date,
           a.update_by,
           a.update_date,
           a.onyx_timestamp,
           a.delete_status
	from work_ticket_audit_log a
	join language l
	on a.site_id = l.site_id
go
grant select on work_ticket_audit_log_rs_view to OnyxPublic
go

