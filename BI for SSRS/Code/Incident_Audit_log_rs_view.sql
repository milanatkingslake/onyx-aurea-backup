/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'incident_audit_log_rs_view' AND type = N'v')
DROP VIEW incident_audit_log_rs_view
GO 	
create view incident_audit_log_rs_view
as
	select a.incident_audit_log_id,
		   a.site_id,
           l.language_code,
		   a.incident_type_did,
		   a.incident_category_did,
		   a.incident_product_code,
		   a.incident_id,
		   a.secondary_id,
		   a.assigned_to,
		   a.labor,
		   a.time,
		   a.primary_contact_id,
		   a.primary_contact_type_enum,
		   a.assigned_id,
		   a.tracking_code_did,
		   a.serial_number,
		   a.desc1,
		   a.desc2,
		   a.source_did,
		   a.status_did,
		   a.priority_did,
		   a.resolution_did1,
		   a.resolution_did2,
		   a.resolution_did3,
		   a.resolution_did4,
		   a.total_time,
		   a.total_labor,
		   a.image,
		   a.read_only_access,
		   a.private_access,
		   a.reminder_date,
		   a.user1,
		   a.user2,
		   a.user3,
		   a.user4,
		   a.user5,
		   a.user6,
		   a.user7,
		   a.user8,
		   a.user9,
		   a.user10,
		   a.insert_by,
		   a.insert_date,
		   a.update_by,
		   a.update_date,
		   a.onyx_timestamp,
		   a.delete_status
	from incident_audit_log a
       JOIN language l
         ON a.site_id          = l.site_id
go
grant select on incident_audit_log_rs_view to OnyxPublic
go

