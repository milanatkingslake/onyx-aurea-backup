/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'address_rs_view' AND type = N'v')
drop view address_rs_view
go
CREATE VIEW [dbo].[address_rs_view] AS
     SELECT a.address_id,
            a.site_id,
            a.owner_id,
            a.address_type_did,
            dbo.ofFormatAddress(a.site_id,
                                l.language_code,
                                a.salutation,
                                a.first_name,
                                a.middle_name,
                                a.last_name,
                                a.suffix,
                                a.address1,
                                a.address2,
                                a.address3,
                                a.locality1,
                                a.region_code,
                                a.country_code,
                                a.post_code,
                                a.company_name,
                                1 -- include company info flag
                                 )  AS formatted_address,

            a.primary_address,
            a.salutation,
            a.first_name,
            a.middle_name,
            a.last_name,
            a.suffix,
            a.company_name,
            a.address1,
            a.address2,
            a.address3,
            a.locality1,
            a.region_code,
--            rg.region_name,
            a.country_code,
--            cy.country_desc,
          dbo.ofApplyMask(a.post_code, cy.post_code_mask) AS post_code_masked,
            a.post_code,
            a.valid_address,
            a.read_only_access,
            a.private_access,
            a.restricted,
            a.insert_by,
            a.insert_date,
            a.update_by,
            a.update_date,
            a.onyx_timestamp,
            a.delete_status,
            l.language_code
       FROM address a
       JOIN language l
         ON a.site_id          = l.site_id
       LEFT OUTER
       JOIN country_ml_view cy         
         ON a.country_code     = cy.country_code
        AND a.site_id          = cy.site_id 
        AND l.language_code    = cy.language_code
go
grant select on address_rs_view to OnyxPublic
go
