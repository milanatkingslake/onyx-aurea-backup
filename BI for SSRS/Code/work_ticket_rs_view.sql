/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_ticket_rs_view' AND type = N'v')
DROP VIEW work_ticket_rs_view
GO 
create view work_ticket_rs_view
as
		select w.work_ticket_id,
			   w.site_id,
               l.language_code,
			   w.secondary_id,
			   w.work_ticket_product_code,
			   w.description,
			   w.type_did,
			   w.source_did,
			   w.status_did,
			   w.priority_did,
			   w.severity_did,
			   w.found_date,
			   w.expected_fix_date,
			   w.fixed_date,
			   w.shipped_date,
			   w.version_found,
			   w.version_fixed,
			   w.version_shipped,
			   w.resolution_did1,
			   w.resolution_did2,
			   w.resolution_did3,
			   w.resolution_did4,
			   dbo.ofKeyWordGetKeyWords(work_ticket_id) AS key_word_list,
			   w.total_time,
			   w.total_labor,
			   w.assigned_to,
			   w.read_only_access,
			   w.private_access,
			   w.user1,
			   w.user2,
			   w.user3,
			   w.user4,
			   w.user5,
			   w.user6,
			   w.user7,
			   w.user8,
			   w.user9,
			   w.user10,
			   w.insert_by,
			   w.insert_date,
			   w.update_by,
			   w.update_date,
			   w.onyx_timestamp,
			   w.delete_status
		from work_ticket w
        JOIN language l
          ON w.site_id          = l.site_id
GO
    
GRANT SELECT ON work_ticket_rs_view TO OnyxPublic
GO

