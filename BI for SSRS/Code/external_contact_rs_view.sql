/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'external_contact_rs_view' AND type = N'v')
DROP VIEW external_contact_rs_view
GO 


CREATE VIEW external_contact_rs_view AS
     SELECT ec.external_contact_id,
            ec.site_id,
            l.language_code,

            ec.contact_type_did,
            ec.contact_for_id,
            ec.contact_for_type_enum,
            ec.contact_id,
            ec.contact_object_id,
            ec.comments,

            ec.insert_by,
            ec.insert_date,
            ec.update_by,
            ec.update_date,

            ec.onyx_timestamp,
            ec.delete_status
       FROM external_contact ec
       JOIN language l
         on ec.site_id = l.site_id
GO

GRANT SELECT ON external_contact_rs_view TO OnyxPublic
GO

