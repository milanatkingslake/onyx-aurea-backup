/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'phone_rs_view' AND type = N'v')
drop VIEW phone_rs_view 
go

CREATE VIEW phone_rs_view AS
     SELECT p.phone_id,
            p.site_id,
            p.owner_id,
            p.owner_type_enum,
            p.phone_type_did,
            l.language_code,
            dbo.ofApplyMask(p.phone_number, c.phone_mask) AS phone_number_masked,
            p.primary_phone,
            p.phone_number,
            p.country_code,
            p.read_only_access,
            p.private_access,
            p.restricted,
            p.insert_by,
            p.insert_date,
            p.update_by,
            p.update_date,
            p.onyx_timestamp,
            p.delete_status
       FROM phone p
       JOIN language l
         ON p.site_id          = l.site_id
       LEFT OUTER
       JOIN country_ml_view c
         ON p.country_code     = c.country_code
        AND p.site_id          = c.site_id     
        AND l.language_code    = c.language_code     
 go
grant select on phone_rs_view to OnyxPublic
go

