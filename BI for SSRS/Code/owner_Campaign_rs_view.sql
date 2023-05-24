/* **ONYX_COPYRIGHT_STRING** */

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'owner_campaign_rs_view' AND type = N'v')
DROP VIEW owner_campaign_rs_view
GO 

CREATE VIEW owner_campaign_rs_view AS
     SELECT oc.owner_campaign_id, 
            oc.site_id, 
            l.language_code, 
            oc.secondary_id, 
            oc.owner_id,
            oc.owner_type_enum, 
            oc.tracking_code_did, 
            oc.read_only_access, 
            oc.private_access, 
            oc.insert_by,
            oc.insert_date,
            oc.update_by,
            oc.update_date,
            oc.delete_status,
            oc.onyx_timestamp,
            oc.user1,
            oc.user2,
            oc.user3,
            oc.user4,
            oc.user5
       FROM owner_campaign oc
       JOIN language l
         on l.site_id = oc.site_id
GO

GRANT SELECT ON owner_campaign_rs_view TO OnyxPublic
GO
