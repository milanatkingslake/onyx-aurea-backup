/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'internal_contact_rs_view' AND type = N'v')
DROP VIEW internal_contact_rs_view
GO 
CREATE VIEW internal_contact_rs_view AS
     SELECT c.internal_contact_id,
            c.site_id,
            l.language_code,
            c.contact_type_did,
            c.owner_id,
            c.owner_type_enum,
            c.user_id,
            c.comments,

            c.insert_by,
            c.insert_date,
            c.update_by,
            c.update_date,
            c.onyx_timestamp,
            c.delete_status
       FROM internal_contact c
       JOIN language l
         ON c.site_id          = l.site_id
go
GRANT SELECT ON internal_contact_rs_view TO OnyxPublic
GO

