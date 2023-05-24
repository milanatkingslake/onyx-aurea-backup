/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'task_rs_view' AND type = N'v')
DROP VIEW task_rs_view
GO 

CREATE VIEW task_rs_view AS
SELECT      task_id,
            t.site_id,
            l.language_code,
            secondary_id,
            owner_id,
            owner_type_enum,
            task_category_did,
            assigned_to,
            primary_contact_id,
--            primary_contact_type_enum,
            task_type_did,
            assigned_id,
            tracking_code_did,
            desc1,
            desc2,
            dbo.ofKeyWordGetKeyWords(task_id)      AS key_word_list,
            status_did,
            priority_did,
            duration,
            duration_units,
            due_by = (select r.due_by FROM reminder r WHERE r.delete_status = 0 and r.owner_id = t.task_id),

            image,
            read_only_access,
            private_access,
            t.insert_by,
            t.insert_date,
            t.update_by,
            t.update_date,
            t.onyx_timestamp,
            t.delete_status,
            user1,
            user2,
            user3,
            user4,
            user5,
            user6,
            user7,
            user8,
            user9,
            user10
       FROM task t
       JOIN language l
         ON t.site_id          = l.site_id
 
GO
GRANT SELECT ON task_rs_view TO OnyxPublic
GO
