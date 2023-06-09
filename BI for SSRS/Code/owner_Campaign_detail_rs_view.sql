/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'owner_campaign_detail_rs_view' AND type = N'v')
drop view owner_campaign_detail_rs_view
go
CREATE VIEW owner_campaign_detail_rs_view AS
     SELECT ocd.owner_campaign_detail_id,
            ocd.site_id,
            ma.language_code,
            ocd.owner_campaign_id,
            ocd.milestone_action_did,
            ocd.action_date,
            ocd.insert_by,
            ocd.insert_date,
            ocd.update_by,
            ocd.update_date,
            ocd.onyx_timestamp,
            ocd.delete_status
       FROM owner_campaign_detail ocd
       JOIN milestone_action_ml_view ma
         ON ocd.milestone_action_did = ma.milestone_action_did
        AND ocd.site_id              = ma.site_id
go
grant select on owner_campaign_detail_rs_view to OnyxPublic
go
