/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'incident_rs_view' AND type = N'v')
DROP VIEW incident_rs_view
GO 
CREATE VIEW incident_rs_view AS
     SELECT i.incident_id,
            i.site_id,
            l.language_code,
            i.secondary_id,
            i.owner_id,
            --i.owner_type_enum,
            i.incident_type_did,
            i.incident_category_did,
            i.incident_product_code,

            i.assigned_to,
            due_by = (select r.due_by FROM reminder r WHERE r.delete_status = 0 and r.owner_id = i.incident_id),

            i.primary_contact_id,
            --i.primary_contact_type_enum,
            i.assigned_id,
            i.tracking_code_did,
            i.serial_number,
            i.desc1,
            i.desc2,
            i.source_did,
            i.status_did,
            i.priority_did,
            i.resolution_did1,
            i.resolution_did2,
            i.resolution_did3,
            i.resolution_did4,
            status_transition_date = (select min(a.insert_date) from incident_audit_log a where a.incident_id= i.incident_id and a.status_did= i.status_did),

            dbo.ofKeyWordGetKeyWords(incident_id)      AS key_word_list,
            i.total_time,
            i.total_labor,
            i.image,
            i.read_only_access,
            i.private_access,
            i.insert_by,
            i.insert_date, --convert(datetime,'1/1/2007') as insert_date, --convert(datetime, convert(varchar,i.insert_date,101)) as insert_date,
            i.update_by,
            i.update_date,
            i.onyx_timestamp,
            i.delete_status,
            i.user1,
            i.user2,
            i.user3,
            i.user4,
            i.user5,
            i.user6,
            i.user7,
            i.user8,
            i.user9,
            i.user10
       FROM incident i
       JOIN language l
         ON i.site_id          = l.site_id
GO
    
GRANT SELECT ON incident_rs_view TO OnyxPublic
GO
