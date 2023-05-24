/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'campaign_tracking_rs_view' AND type = N'v')
drop view campaign_tracking_rs_view
go
create view Campaign_tracking_rs_view
as
     
SELECT      tc.site_id, 
            tc.language_code, 
            tc.tracking_code_did, 
            tc.tracking_code,
            tc.tracking_name,
            tc.tracking_desc,
            c.campaign_code,
            c.campaign_name,
            c.campaign_desc,

            tct.tracking_code_type_did,
            tct.tracking_type_name,
            tct.tracking_type_desc
       FROM tracking_code_ml_view tc 
       JOIN tracking_code_type_ml_view tct 
         ON tc.tracking_code_type_did = tct.tracking_code_type_did
        AND tc.site_id                = tct.site_id               
        AND tc.language_code          = tct.language_code         
       JOIN campaign_ml_view c 
         ON tc.campaign_code          = c.campaign_code  
        AND tc.site_id                = c.site_id        
        AND tc.language_code          = c.language_code
go
grant select on campaign_tracking_rs_view to onyxpublic
go

