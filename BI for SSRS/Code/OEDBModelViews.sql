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
            a.owner_type_enum,
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

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'contact_type_rs_view' AND type = N'v')
drop view contact_type_rs_view
go
create view contact_type_rs_view
as
select contact_type_did,
       site_id,
       language_code,
       contact_type_attributes,
       contact_category_did,  -- enum
       contact_group_type_did,  -- internal (2), external (1)
       contact_type_desc,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status  
from contact_type_ml_view 
-- ct.contact_group_type_did = 2  -- internal contact types
go
grant select on contact_type_rs_view to OnyxPublic
go
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'currency_rs_view' AND type = N'v')
drop view currency_rs_view
go
create view currency_rs_view
as
select currency_code,
       site_id,
       language_code,
       locale_code,
       currency_desc,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status 
from currency_ml_view
go
grant select on currency_rs_view to OnyxPublic
go
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'customer_rs_view' AND type = N'v')
drop VIEW customer_rs_view 
go

/*
** ObjectName: customer_rs_view
**
** Description:
**
** 
*/

CREATE VIEW customer_rs_view AS
SELECT site_id,
       language_code,
       object_id,
       
       secondary_id,
       object_type_enum,
       assigned_id,
       dbo.ofFormatName (object_type_enum, company_name, 
                          salutation, first_name, middle_name, 
                          last_name, suffix,language_code) as customer_name ,                         
       Customer_type_did,
       Customer_subtype_did,
       source_did,
       status_did,
       email_address,
       url,
       company_name,
       read_only_access,
       private_access,
       insert_by,
       insert_date,
       update_by,
       update_date,
       delete_status,
       onyx_timestamp,

/* Company Only Fields */
       primary_contact_id,
       company_family_did,
       tax_identification_number,
       dunns_number,
       sic_code,
       market_sector_did,
       division_did,
       parent_company_id,
       parent_company_name,

/* Individual Only Fields */
       salutation,
       first_name,
       middle_name,
       last_name,
       suffix,
       gender,
       title_code,
       title_desc,
       department_code,
       department_desc,
       individual_company_id,
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

FROM 
   (
     SELECT 
/* Customer Fields */
            i.site_id,                                     
            l.language_code,                               
			i.company_id                                   AS object_id,

            i.secondary_id, 
            2                                              AS object_type_enum,
            i.assigned_id,
            i.company_type_did                             AS Customer_type_did,
            i.company_sub_type_did                         AS Customer_subtype_did,
            i.source_did,
            i.status_did,
            dbo.ofEmailAddressGetPrimaryEmailAddress(i.company_id)  AS email_address,
            i.url,
            i.company_name,                               

            i.read_only_access,
            i.private_access,
            i.insert_by,
            i.insert_date,
            i.update_by,
            i.update_date,
            i.delete_status,
            i.onyx_timestamp,

/* Company Only Fields */
            i.primary_contact_id,
            i.company_family_did,
            i.tax_identification_number,
            i.dunns_number,
            i.sic_code,
            i.market_sector_did,
            i.division_did,
            i.parent_company_id,
            pcomp.company_name as parent_company_name,

/* Individual Only Fields */
            NULL                                           AS salutation,
            NULL                                           AS first_name,
            NULL                                           AS middle_name,
            NULL                                           AS last_name,
            NULL                                           AS suffix,
            NULL                                           AS gender,
-- make these lookups?
            NULL                                           AS title_code,
            NULL                                           AS title_desc,
            NULL                                           AS department_code,
            NULL                                           AS department_desc,
            NULL                                           AS individual_company_id,
/* UDFs */
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

       FROM company i
       LEFT OUTER
       JOIN company pcomp
         on pcomp.site_id = i.site_id and pcomp.company_id = i.parent_company_id
       JOIN language l
         ON i.site_id          = l.site_id
   UNION
     SELECT 
/* Customer Fields */
            i.site_id,                                       
            l.language_code,                                 
            i.individual_id                                AS object_id,
            
            i.secondary_id,                                  
            1                                              AS object_type_enum,
            i.assigned_id,
            i.user_type_did                                AS Customer_type_did,
            i.user_sub_type_did                            AS Customer_subtype_did,
            i.source_did,
            i.status_did,
           dbo.ofEmailAddressGetPrimaryEmailAddress(i.individual_id) AS email_address ,
            i.url,
            i.company_name,

            i.read_only_access,
            i.private_access,
            i.insert_by,
            i.insert_date,
            i.update_by,
            i.update_date,
            i.delete_status,
            i.onyx_timestamp,

/* Company Only Fields */
            NULL                                           AS primary_contact_id,
            NULL                                           AS primary_contact_name,
            NULL                                           AS company_family_did,
            NULL                                           AS tax_identification_number,
            NULL                                           AS dunns_number,
            NULL                                           AS sic_code,
            NULL                                           AS market_sector_did,
            NULL                                           AS division_did,
            NULL                                           AS parent_company_id,

/* Individual Only Fields */
            i.salutation,
            i.first_name,
            i.middle_name,
            i.last_name,
            i.suffix,
            i.gender,
       
            i.title_code,
            i.title_desc,
            i.department_code,
            i.department_desc,
            i.company_id                               AS individual_company_id,

/* UDFs */
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

       FROM individual i
       JOIN language l
         ON i.site_id          = l.site_id
) Cust
go
grant select on customer_rs_view to OnyxPublic, public
go
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

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'forecast_detail_rs_view' AND type = N'v')
drop view forecast_detail_rs_view 
go
create view forecast_detail_rs_view 
as 
select f.forecast_detail_id,
       f.site_id,
       l.language_code, 
       f.forecast_header_id,
       f.product_code,
       f.line_number,
       f.forecast_detail_desc,
       f.quantity,
       f.discount_type_did,
       f.primary_unit_price,
       f.primary_discount,
       f.secondary_discounted, 
       f.primary_discounted, 
       f.primary_extended, 
       f.secondary_extended,
       f.secondary_unit_price,
       f.secondary_discount,
       f.confidence_factor,
       f.ship_date,
       f.comments,
       f.read_only_access,
       f.private_access,
       f.user1,
       f.user2,
       f.user3,
       f.user4,
       f.user5,
       f.user6,
       f.user7,
       f.user8,
       f.user9,
       f.user10,
       f.insert_by,
       f.insert_date,
       f.update_by,
       f.update_date,
       f.onyx_timestamp,
       f.delete_status
       
from forecast_detail f 
     join language l on l.site_id = f.site_id 
go
grant select on forecast_detail_rs_view  to OnyxPublic
go
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'forecast_header_rs_view' AND type = N'v')
drop view forecast_header_rs_view 
go
create view forecast_header_rs_view 
as
select f.forecast_header_id,
       l.language_code,
       f.site_id,
       f.secondary_id,
       f.owner_id,
       f.owner_type_enum,
       f.primary_currency_code,
       f.secondary_currency_code,
       f.name,
       f.assigned_id,
       f.status_did,
       f.exchange_rate_date,
       f.create_date,
       f.user_commit, 
       f.user_most_likely, 
       f.user_upside, 
       f.user_commit1, 
       f.user_most_likely1, 
       f.user_upside1, 
       f.user_commit2, 
       f.user_most_likely2, 
       f.user_upside2, 
       f.booked_amount, 
       f.total_cost1, 
       f.total_discount1, 
       f.confidence_weighted1, 
       f.calculated_forecast1, 
       f.total_cost2, 
       f.total_discount2, 
       f.confidence_weighted2, 
       f.calculated_forecast2,
       f.close_probability,
       f.close_date,
       f.expiration_date,
       f.comments,
       f.read_only_access,
       f.private_access,
       f.user1,
       f.user2,
       f.user3,
       f.user4,
       f.user5,
       f.user6,
       f.user7,
       f.user8,
       f.user9,
       f.user10,
       f.insert_by,
       f.insert_date,
       f.update_by,
       f.update_date,
       f.onyx_timestamp,
       f.delete_status
 from forecast_header f 
      join language l on l.site_id = f.site_id
go
grant select on forecast_header_rs_view to OnyxPublic
go




IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'user_group_rs_view' AND type = N'v')
DROP VIEW user_group_rs_view
GO 

CREATE VIEW user_group_rs_view AS
     SELECT    group_code,
			   site_id,
			   language_code,

			   group_desc,
			   manager_id,
			   parent_user_group_code,

			   authority_id,
			   detail_access,
			   escalation_id,
			   email_alias,
			   insert_by,
			   insert_date,
			   update_by,
			   update_date,
			   onyx_timestamp,
			   record_status
from user_group_ml_view
go

GRANT SELECT ON user_group_rs_view TO OnyxPublic
GO
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'incident_audit_log_rs_view' AND type = N'v')
DROP VIEW incident_audit_log_rs_view
GO 	
create view incident_audit_log_rs_view
as
	select a.incident_audit_log_id,
		   a.site_id,
           l.language_code,
		   a.incident_type_did,
		   a.incident_category_did,
		   a.incident_product_code,
		   a.incident_id,
		   a.secondary_id,
		   a.assigned_to,
		   a.labor,
		   a.time,
		   a.primary_contact_id,
		   a.primary_contact_type_enum,
		   a.assigned_id,
		   a.tracking_code_did,
		   a.serial_number,
		   a.desc1,
		   a.desc2,
		   a.source_did,
		   a.status_did,
		   a.priority_did,
		   a.resolution_did1,
		   a.resolution_did2,
		   a.resolution_did3,
		   a.resolution_did4,
		   a.total_time,
		   a.total_labor,
		   a.image,
		   a.read_only_access,
		   a.private_access,
		   a.reminder_date,
		   a.user1,
		   a.user2,
		   a.user3,
		   a.user4,
		   a.user5,
		   a.user6,
		   a.user7,
		   a.user8,
		   a.user9,
		   a.user10,
		   a.insert_by,
		   a.insert_date,
		   a.update_by,
		   a.update_date,
		   a.onyx_timestamp,
		   a.delete_status
	from incident_audit_log a
       JOIN language l
         ON a.site_id          = l.site_id
go
grant select on incident_audit_log_rs_view to OnyxPublic
go

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'incident_product_rs_view' AND type = N'v')
drop view incident_product_rs_view
go
create view incident_product_rs_view
as
select incident_product_code,
       site_id,
       language_code,
       incident_category_did,
       alternate_id,
       resolution_group,
       status_did,
       incident_product_desc,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status
from incident_product_ml_view
go
grant select on incident_product_rs_view to OnyxPublic
go



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

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'milestone_action_rs_view' AND type = N'v')
drop view milestone_action_rs_view
go
create view milestone_action_rs_view
as
select milestone_action_did,
       site_id,
       language_code,
       milestone_action_name,
       milestone_action_desc,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status
from milestone_action_ml_view
go
grant select on milestone_action_rs_view to OnyxPublic
go
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

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'product_group_rs_view' AND type = N'v')
drop view product_group_rs_view
go
create view product_group_rs_view
as
select product_group_did,
       site_id,
       language_code,
       rank,
       parent_product_group_did,
       product_group_desc,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status
from product_group_ml_view
go
grant select on product_group_rs_view to OnyxPublic
go
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'product_header_rs_view' AND type = N'v')
DROP VIEW product_header_rs_view
GO 

CREATE VIEW product_header_rs_view AS
     SELECT ph.product_header_id,
            ph.site_id,
            l.language_code,
            ph.secondary_id,
            ph.owner_id,
            ph.owner_type_enum,
            ph.product_code,
            ph.primary_contact_id,
            ph.serial_number,
            ph.quantity,
            ph.purchase_date,
            ph.tracking_code_did,
            ph.source_did,
            ph.status_did,
            ph.read_only_access,
            ph.private_access,
            ph.insert_by,
            ph.insert_date,
            ph.update_by,
            ph.update_date,
            ph.onyx_timestamp,
            ph.delete_status,
            ph.user1,
            ph.user2,
            ph.user3,
            ph.user4,
            ph.user5,
            ph.user6,
            ph.user7,
            ph.user8,
            ph.user9,
            ph.user10
       FROM product_header ph
       JOIN Language l
         on l.site_id = ph.site_id

GO
GRANT SELECT ON product_header_rs_view TO OnyxPublic
GO

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'product_rs_view' AND type = N'v')
drop view product_rs_view
go
create view product_rs_view
as
select product_code,
       site_id,
       language_code,
       product_group_did,
       product_support_type,
       incident_product_code,
       currency_code,
       alternate_product_number,
       stock_level,
       list_price,
       cost,
       warranty_calls,
       warranty_days,
       warranty_exp_date,
       orderable,
       first_ship_date,
       obsolete_date,
       status_did,
       product_desc,
       user1,
       user2,
       user3,
       user4,
       user5,
       user6,
       user7,
       user8,
       user9,
       user10,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status
from product_ml_view
go
grant select on product_rs_view to OnyxPublic
go

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'quote_detail_rs_view' AND type = N'v')
drop view quote_detail_rs_view 
go
create view quote_detail_rs_view 
as 
select q.quote_detail_id,
       q.site_id,
       l.language_code,
       q.quote_header_id,
       q.line_number,
       q.quote_detail_desc,
       q.product_code,
       q.quantity,
       q.discount_type_did,
       q.primary_unit_price,
       q.primary_discount,
       q.secondary_unit_price,
       q.secondary_discount,
       q.primary_extended, 
       q.secondary_extended, 
       q.primary_discounted, 
       q.secondary_discounted,
       q.confidence_factor,
       q.ship_date,
       q.comments,
       q.read_only_access,
       q.private_access,
       q.user1,
       q.user2,
       q.user3,
       q.user4,
       q.user5,
       q.user6,
       q.user7,
       q.user8,
       q.user9,
       q.user10,
       q.insert_by,
       q.insert_date,
       q.update_by,
       q.update_date,
       q.onyx_timestamp,
       q.delete_status
from quote_detail q
     join language l on l.site_id = q.site_id 
go
grant select on quote_detail_rs_view  to OnyxPublic
go
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'quote_header_rs_view' AND type = N'v')
drop view quote_header_rs_view 
go
create view quote_header_rs_view 
as
select q.quote_header_id,
       q.site_id,
       l.language_code,
       q.secondary_id,
       q.owner_id,
       q.owner_type_enum,
       q.name,
       q.assigned_id,
       q.document_path,
       q.status_did,
       q.primary_currency_code,
       q.secondary_currency_code,
       q.exchange_rate_date,
       q.create_date,
       q.close_probability,
       q.close_date,
       q.expiration_date,
       q.total_cost1, 
       q.total_discount1, 
       q.total_cost2, 
       q.total_discount2,
       q.comments,
       q.read_only_access,
       q.private_access,
       q.user1,
       q.user2,
       q.user3,
       q.user4,
       q.user5,
       q.user6,
       q.user7,
       q.user8,
       q.user9,
       q.user10,
       q.insert_by,
       q.insert_date,
       q.update_by,
       q.update_date,
       q.onyx_timestamp,
       q.delete_status
from quote_header q
      join language l on l.site_id = q.site_id
go
grant select on quote_header_rs_view to OnyxPublic
go  

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'reference_lookup_rs_view' AND type = N'v')
drop view reference_lookup_rs_view
go
CREATE VIEW reference_lookup_rs_view AS
     SELECT rl.reference_did,
            rl.reference_parameter_did,
            rl.parent_did,
            rl.site_id,
            rl.extra_data,
            rl.character_code,
            rl.seq_num,
            rf.reference_field_name,
            rf.parent_reference_field_did,
            rf.field_mask,
            rp.language_code,
            rp.parameter_desc,
            rl.insert_by,
            rl.insert_date,
            rl.update_by,
            rl.update_date,
            rl.onyx_timestamp
       FROM reference_lookup rl
       JOIN reference_field rf 
         ON rl.reference_did           = rf.reference_did
        AND rl.site_id                 = rf.site_id      
       JOIN reference_parameter_ml_view rp
         ON rl.reference_parameter_did = rp.reference_parameter_did
        AND rl.site_id                 = rp.site_id      
go
grant select on reference_lookup_rs_view to OnyxPublic
go
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'reference_parameter_rs_view' AND type = N'v')
drop view reference_parameter_rs_view
go
CREATE VIEW reference_parameter_rs_view AS
     SELECT reference_parameter_did,
		   site_id,
		   language_code,
		   parameter_desc,
		   insert_by,
		   insert_date,
		   update_by,
		   update_date,
		   onyx_timestamp,
		   record_status
       FROM reference_parameter_ml_view
go
grant select on reference_parameter_rs_view to OnyxPublic
go

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
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'users_rs_view' AND type = N'v')
DROP VIEW users_rs_view
GO 

/*
** ObjectName: users_rs_view
**
** Description:
**
** Revision History:
** ----------------------------------------------------------------------------
**  Date        Name        Description
** ----------------------------------------------------------------------------
*/
CREATE VIEW users_rs_view AS
     SELECT u.user_id,
            u.site_id,
            l.language_code,
            u.user_name,
            u.email_alias,
            network_user = (select min(network_user) from network_user n where n.user_id = u.user_id and n.site_id = u.site_id),
            
	        u.manager_id,
            u.group_code,
            
            u.authority_id,
            u.detail_add,
            u.detail_delete,
            u.detail_view,
            u.security_id,
            u.language_code as user_language_code,
            u.computer_name,
            u.last_login_date,
            u.password,
            u.allow_auth_types,
            u.allow_impersonate,
            u.insert_by,
            u.insert_date,
            u.update_by,
            u.update_date,
            u.record_status,
            l.language_code             AS ml_language_code,
            u.onyx_timestamp
       FROM users u
       JOIN language l
         ON u.site_id       = l.site_id
GO

GRANT SELECT ON users_rs_view TO OnyxPublic
GO
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_note_rs_view' AND type = N'v')
drop view work_note_rs_view
go
create view work_note_rs_view
as
	Select work_note_detail_id,
			h.work_note_header_id,
            h.owner_id,
            l.language_code,
			h.site_id,
			seq_num,
			logmark,
			logmark_sequence,
			publish_bit_mask,
			convert(nvarchar(4000), work_note)  as  work_note,
			d.insert_by,
			d.insert_date,
			d.update_by,
			d.update_date,
			d.onyx_timestamp,
			h.owner_type_enum

	from work_note_detail d
    join language l
      on l.site_id = d.site_id
    join work_note_header h
      on d.work_note_header_id = h.work_note_header_id
      and h.delete_status = 0 
    where d.delete_status = 0

go
grant select on work_note_rs_view to OnyxPublic
go

IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_ticket_association_rs_view' AND type = N'v')
DROP VIEW work_ticket_association_rs_view
GO 
create view work_ticket_association_rs_view
as	
    select w.work_ticket_association_id,
           w.site_id,
           l.language_code,
           w.work_ticket_id,
           w.associated_object_id,
           w.associated_object_type_enum,
           w.insert_by,
           w.insert_date,
           w.update_by,
           w.update_date,
           w.onyx_timestamp,
           w.delete_status
	from work_ticket_association w
	join language l
	   on w.site_id = l.site_id

	UNION

    select w.work_ticket_association_id,
           w.site_id,
           l.language_code,
           w.associated_object_id,  -- reversed to get the other worktickts that this one is linked to via reverse relationship
           w.work_ticket_id,
           w.associated_object_type_enum,
           w.insert_by,
           w.insert_date,
           w.update_by,
           w.update_date,
           w.onyx_timestamp,
           w.delete_status
	from work_ticket_association w
	join language l
	   on w.site_id = l.site_id
    where associated_object_type_enum = 10

    UNION

	select w.work_ticket_association_id,
			   w.site_id,
			   l.language_code,
			   w.work_ticket_id,
			   i.owner_id,
			   i.owner_type_enum,
			   w.insert_by,
			   w.insert_date,
			   w.update_by,
			   w.update_date,
			   w.onyx_timestamp,
			   w.delete_status
		from work_ticket_association w
        join incident i
          on i.incident_id = w.associated_object_id
		join language l
		   on w.site_id = l.site_id
           and l.site_id = i.site_id
go
grant select on work_ticket_association_rs_view to OnyxPublic
go


IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_ticket_audit_log_rs_view' AND type = N'v')
DROP VIEW work_ticket_audit_log_rs_view
GO 
create view work_ticket_audit_log_rs_view
as	
	select a.work_ticket_audit_log_id,
           a.work_ticket_id,
           a.site_id,
	       l.language_code,
           a.secondary_id,
           a.work_ticket_product_code,
           a.description,
           a.type_did,
           a.source_did,
           a.status_did,
           a.priority_did,
           a.severity_did,
           a.found_date,
           a.expected_fix_date,
           a.fixed_date,
           a.shipped_date,
           a.version_found,
           a.version_fixed,
           a.version_shipped,
           a.resolution_did1,
           a.resolution_did2,
           a.resolution_did3,
           a.resolution_did4,
           a.total_time,
           a.total_labor,
           a.time,
           a.labor,
           a.assigned_to,
           a.read_only_access,
           a.private_access,
           a.insert_by,
           a.insert_date,
           a.update_by,
           a.update_date,
           a.onyx_timestamp,
           a.delete_status
	from work_ticket_audit_log a
	join language l
	on a.site_id = l.site_id
go
grant select on work_ticket_audit_log_rs_view to OnyxPublic
go

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

GO
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'email_rs_view'))
DROP VIEW email_rs_view
GO


/****** Object:  View [dbo].[email_rs_view]    Script Date: 06/21/2009 20:34:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[email_rs_view]
AS
SELECT DISTINCT 
                      em.email_message_id, em.secondary_id AS Email_Id, em.site_id, l.language_code, em.subject, em.text, em.thread_id, em.sent, em.sent_date, em.received_date, 
                      em.processed_date, em.follow_up, em.priority, em.insert_by, em.insert_date, em.update_by, em.update_date, em.delete_status, ea.associated_with_type_enum, 
                      ea.associated_with_id
FROM         dbo.email_message AS em INNER JOIN
                      dbo.language AS l ON l.site_id = em.site_id INNER JOIN
                      dbo.email_association AS ea ON em.email_message_id = ea.email_message_id

GO
grant select on email_rs_view to OnyxPublic

GO

/****** Object:  View [dbo].[email_contact_rs_view]    Script Date: 06/21/2009 20:36:32 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'email_contact_rs_view'))
DROP VIEW email_contact_rs_view
GO



/****** Object:  View [dbo].[email_contact_rs_view]    Script Date: 06/21/2009 20:36:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE View email_contact_rs_view
       as 
       SELECT   ec.email_contact_id as email_contact_id,
				ect.language_code as language_code, 
				ect.email_contact_type_name as email_contact_type_name, 
				ec.display_name as display_name, 
                ec.email_address as email_address, 
                ec.contact_is_resolved as contact_is_resolved, 
                ec.email_message_id as email_message_id, 
                ec.site_id as site_id, 
                ec.email_contact_type_did as email_contact_type_did ,
                ec.delete_status as delete_status
                
FROM         email_contact_type_ml_view  as ect 
			INNER JOIN dbo.email_contact as ec 
            ON ect.email_contact_type_did = ec.email_contact_type_did
       
GO
grant select on email_contact_rs_view to OnyxPublic

GO

/****** Object:  View [dbo].[script_rs_view]    Script Date: 06/21/2009 20:41:38 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'script_rs_view'))
DROP VIEW script_rs_view
GO
/****** Object:  View [dbo].[script_rs_view]    Script Date: 06/25/2009 05:12:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[script_rs_view]
AS
SELECT     ss.script_session_id, ss.script_did, ss.script_desc, ss.script_group_name, ss.primary_contact_secondary_id, ss.site_id, l.language_code, ss.duration, ss.status_did,
                       ss.insert_date, ss.update_date, ss.update_by, ss.insert_by, ss.delete_status, sss.completed, sss.script_step_did, sss.script_step_name, sss.script_step_desc, 
                      sss.sequence_number, CAST(sss.header_text AS nvarchar(4000)) AS header_text, CAST(sss.footer_text AS nvarchar(4000)) AS footer_text, 
                      ssp.script_session_step_id, ssp.script_prompt_did, ssp.script_prompt_name, ssp.sequence_number AS Prompt_Sequence, CAST(ssp.text AS nvarchar(4000)) AS text, 
                      ssp.control_type_name, ssp.response_code, ssp.value, ssp.additional_text, ssp.script_session_response_id, ss.primary_contact_id, ss.owner_id, 
                      ss.owner_type_enum
FROM         dbo.script_session_oa_view AS ss INNER JOIN
                      dbo.language AS l ON ss.language_code = l.language_code LEFT OUTER JOIN
                          (SELECT     script_session_step_id, site_id, script_session_id, script_step_did, language_code, script_step_name, script_step_desc, header_text, footer_text, 
                                                   sequence_number, completed, insert_by, insert_date, update_by, update_date, delete_status, onyx_timestamp
                            FROM          dbo.script_session_step_oa_view
                            WHERE      (delete_status = 0)) AS sss ON ss.script_session_id = sss.script_session_id LEFT OUTER JOIN
                          (SELECT     script_session_response_id, site_id, script_session_step_id, script_prompt_did, language_code, sequence_number, script_prompt_name, text, 
                                                   data_type_enum, control_type_code, control_type_name, control_type_desc, response_code, value, additional_text, insert_by, insert_date, update_by, 
                                                   update_date, delete_status, onyx_timestamp
                            FROM          dbo.script_session_prompt_response_oa_view
                            WHERE      (delete_status = 0)) AS ssp ON sss.script_session_step_id = ssp.script_session_step_id



GO
grant select on script_rs_view to OnyxPublic
GO

/****** Object:  View [dbo].[Survey_rs_view]    Script Date: 06/21/2009 20:43:52 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'survey_rs_view'))
DROP VIEW survey_rs_view
GO


CREATE VIEW survey_rs_view
AS
SELECT DISTINCT 
                      rmv.response_text AS Response, 
                      osa.owner_survey_association_id AS Profile_ID, 
                      osa.survey_did AS Survey_id, 
                      osa.survey_type_desc AS Type, 
                      osa.survey_name AS Name, 
                      osa.survey_desc AS Description, 
                      osa.question_did AS Question_Id, 
                      osa.question_type_enum AS Question_Type, 
                      osa.question_text AS Question, 
                      osa.sequence_number, 
                      oqr.response_did, 
                      osa.site_id, 
                      osa.insert_by, 
                      osa.insert_date, 
                      osa.update_by, 
                      osa.update_date, 
                      osa.delete_status, 
                      osa.owner_id, 
                      osa.owner_type_enum, 
                      rmv.language_code, 
                      osa.survey_type_did
FROM         (SELECT     owner_question_response_id, site_id, owner_id, owner_type_enum, question_did, response_did, response_free_text, insert_by, insert_date, update_by, 
                                              update_date, onyx_timestamp, delete_status
                       FROM         owner_question_response
                       WHERE      (delete_status = 0)) AS oqr INNER JOIN
                      response_ml_view AS rmv ON oqr.response_did = rmv.response_did AND oqr.site_id = rmv.site_id RIGHT OUTER JOIN
                      owner_survey_association_oa_view AS osa ON oqr.question_did = osa.question_did AND oqr.owner_id = osa.owner_id

GO
grant select on survey_rs_view to OnyxPublic
GO

/****** Object:  View [dbo].[Literature_rs_view]    Script Date: 06/21/2009 20:49:34 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'literature_rs_view'))
DROP VIEW literature_rs_view
GO






SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW literature_rs_view
AS
SELECT     loh.site_id, lod.language_code, loh.secondary_id, loh.order_date, lsv.literature_ship_via_desc, ISNULL(loh.header_comment1, '') 
                      + ' ' + ISNULL(loh.header_comment2, '') AS Comments, loh.customer_reference, loh.fob, lt.literature_term_desc, ISNULL(loh.ship_to_address1 + CHAR(13) + CHAR(10), 
                      '') + ISNULL(loh.ship_to_address2 + CHAR(13) + CHAR(10), '') + ISNULL(loh.ship_to_address3 + CHAR(13) + CHAR(10), '') + ISNULL(loh.ship_to_address4 + CHAR(13) 
                      + CHAR(10), '') + ISNULL(loh.ship_to_address5 + CHAR(13) + CHAR(10), '') + ISNULL(loh.ship_to_address6 + CHAR(13) + CHAR(10), '') 
                      + ISNULL(loh.ship_to_address7 + CHAR(13) + CHAR(10), '') + ISNULL(loh.ship_to_address8 + CHAR(13) + CHAR(10), '') AS Ship_To_Address, loh.fax_phone_number, 
                      loh.email_to, lm.description, loh.literature_ship_via_did, loh.insert_by, loh.insert_date, loh.update_by, loh.update_date, lod.line_number, ols.order_line_status_name, 
                      lod.literature_product_code, lod.product_desc, lod.quantity_ordered, lod.quantity_shipped, lod.ship_date, lod.immediate_priority, lp.is_label, 
                      loh.literature_order_header_id, lod.literature_order_detail_id, loh.tracking_code_did, loh.delete_status, loh.owner_id, loh.owner_type_enum
FROM         dbo.literature_order_header AS loh INNER JOIN
                          (SELECT     literature_order_detail_id, literature_order_header_id, site_id, line_number, literature_product_code, literature_order_batch_id, language_code, 
                                                   product_desc, fulfillment_type_name, engine_name, allow_as_email_attachment, is_label, outbound_file_path, order_line_status_code, source_did, 
                                                   ship_date, unit_price, quantity_ordered, quantity_shipped, discount_percent, extended_price, printer_name, detail_comment1, detail_comment2, 
                                                   fulfillment_type_code, immediate_priority, ops_system_attributes, subsystem_did, scheduled_process_date, insert_by, insert_date, update_by, 
                                                   update_date, onyx_timestamp, delete_status
                            FROM          dbo.literature_order_detail_oa_view
                            WHERE      (delete_status = 0)) AS lod ON loh.literature_order_header_id = lod.literature_order_header_id INNER JOIN
                      dbo.order_line_status_ml_view AS ols ON lod.order_line_status_code = ols.order_line_status_code LEFT OUTER JOIN
                      dbo.literature_product AS lp ON lod.literature_product_code = lp.literature_product_code LEFT OUTER JOIN
                      dbo.literature_term_ml_view AS lt ON loh.literature_term_did = lt.literature_term_did LEFT OUTER JOIN
                      dbo.literature_ship_via_ml_view AS lsv ON loh.literature_ship_via_did = lsv.literature_ship_via_did LEFT OUTER JOIN
                          (SELECT     literature_message_id, site_id, reusable, description, text, private_access, insert_by, insert_date, update_by, update_date, onyx_timestamp, 
                                                   delete_status
                            FROM          dbo.literature_message
                            WHERE      (delete_status = 0)) AS lm ON loh.literature_message_id = lm.literature_message_id

GO
grant select on literature_rs_view to OnyxPublic
GO
/****** Object:  View [dbo].[Tracking_code_rs_view]    Script Date: 06/21/2009 20:51:24 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'tracking_code_rs_view'))
DROP VIEW tracking_code_rs_view
GO
CREATE VIEW tracking_code_rs_view
AS
SELECT		language_code, 
			site_id, 
			record_status, 
			tracking_code, 
			campaign_code, 
			campaign_name, 
			tracking_code_did
FROM         tracking_code_oa_view AS tc

GO
grant select on tracking_code_rs_view to OnyxPublic
GO

/****** Object:  View assignment_rs_view    Script Date: 07/08/2009 00:20:29 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'assignment_rs_view'))
DROP VIEW assignment_rs_view

GO

CREATE VIEW assignment_rs_view
AS
SELECT     almv.site_id, almv.language_code, almv.assignment_territory_name, almv.assignment_territory_desc, almv.parent_assignment_territory_did, 
                      almv.sequence_number, almv.record_status, aa.associated_with_id, aa.associated_with_type_enum, almv.insert_by, almv.insert_date, almv.update_by, 
                      almv.update_date, aa.assignment_association_id, almv.assignment_territory_did
FROM         assignment_territory_ml_view AS almv LEFT OUTER JOIN
                          (SELECT     assignment_association_id, site_id, assignment_territory_did, associated_with_id, associated_with_type_enum, insert_by, insert_date, update_by, 
                                                   update_date, delete_status, onyx_timestamp
                            FROM          assignment_association
                            WHERE      (delete_status = 0)) AS aa ON almv.assignment_territory_did = aa.assignment_territory_did

GO
grant select on assignment_rs_view to OnyxPublic
GO


/****** Object:  View assignment_condition_rs_view    Script Date: 07/08/2009 00:20:12 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'assignment_condition_rs_view'))
DROP VIEW assignment_condition_rs_view
GO

CREATE VIEW assignment_condition_rs_view
AS
SELECT     asmv.assignment_set_desc, asmv.assignment_set_name, ae.property_name, ae.property_value1, ae.property_value2, acmv.assignment_condition_desc, 
                      acmv.assignment_condition_name, acmv.sequence_number, asc1.sequence_number AS condition_sequence_number, asu.user_id, asu.internal_contact_type_did, 
                      ae.operator, asu.assigned_to_flag, asu.sequence_number AS user_sequence_number, acmv.assignment_territory_did, acmv.assignment_condition_did, 
                      acmv.record_status, acmv.site_id, acmv.language_code, acmv.object_type_enum, asmv.assignment_type_bitmask, ae.assignment_expression_did, 
                      asmv.assignment_set_did, asu.assignment_set_user_did, acmv.insert_by, acmv.insert_date, acmv.update_by, acmv.update_date
FROM         assignment_set_user AS asu RIGHT OUTER JOIN
                          (SELECT     assignment_set_did, site_id, language_code, assignment_set_name, assignment_set_desc, object_type_enum, assignment_type_bitmask, insert_by, 
                                                   insert_date, update_by, update_date, record_status, onyx_timestamp
                            FROM          dbo.assignment_set_ml_view
                            WHERE      (record_status = 1)) AS asmv LEFT OUTER JOIN
                      assignment_set_condition AS asc1 ON asmv.assignment_set_did = asc1.assignment_set_did ON 
                      asu.assignment_set_did = asmv.assignment_set_did RIGHT OUTER JOIN
                      assignment_expression AS ae RIGHT OUTER JOIN
                      assignment_condition_ml_view AS acmv ON ae.assignment_condition_did = acmv.assignment_condition_did ON 
                      asc1.assignment_condition_did = acmv.assignment_condition_did

GO
grant select on assignment_condition_rs_view to OnyxPublic
GO
/****** Object:  View appointment_rs_view    Script Date: 07/08/2009 00:29:19 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'appointment_rs_view'))
DROP VIEW appointment_rs_view
GO



CREATE VIEW appointment_rs_view
AS
SELECT     l.language_code, a.site_id, a.appointment_id, a.external_appointment_id, a.subject, a.location, a.start_date, a.end_date, a.all_day, a.recurrence, a.private, 
                      a.calendar_reminder, a.reminder_minutes, a.body, a.cancelled, a.insert_by, a.insert_date, a.update_by, a.update_date, a.delete_status, aa.associated_with_id, 
                      aa.associated_with_type_enum
FROM         appointment AS a INNER JOIN
                      language AS l ON a.site_id = l.site_id LEFT OUTER JOIN
                          (SELECT     appointment_association_id, site_id, appointment_id, associated_with_id, associated_with_type_enum, insert_by, insert_date, update_by, update_date, 
                                                   onyx_timestamp, delete_status
                            FROM          appointment_association
                            WHERE      (delete_status = 0)) AS aa ON a.appointment_id = aa.appointment_id


GO
grant select on appointment_rs_view to OnyxPublic
GO



/****** Object:  View appointment_attendee_rs_view    Script Date: 07/08/2009 00:29:02 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'appointment_attendee_rs_view'))
DROP VIEW appointment_attendee_rs_view
GO


CREATE VIEW appointment_attendee_rs_view
AS
SELECT     aa.appointment_attendee_id, aa.owner_id, aa.display_name, aa.email_address, aa.attendee_type_code, aa.insert_by, aa.insert_date, aa.update_by, aa.update_date, 
                      aa.delete_status, aatm.name AS Type_Name, aatm.language_code, aa.site_id
FROM         appointment_attendee AS aa LEFT OUTER JOIN
                          (SELECT     attendee_type_code, site_id, language_code, name, insert_by, insert_date, update_by, update_date, onyx_timestamp, record_status
                            FROM          appointment_attendee_type_ml_view
                            WHERE      (record_status = 1)) AS aatm ON aa.attendee_type_code = aatm.attendee_type_code

GO
grant select on appointment_attendee_rs_view to OnyxPublic
GO
/****** Object:  View comments_rs_view    Script Date: 07/08/2009 00:34:15 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'comments_rs_view'))
DROP VIEW comments_rs_view
GO

CREATE VIEW comments_rs_view
AS
SELECT     n.note_id, n.site_id, n.secondary_id, n.owner_id, n.owner_type_enum, l.language_code, n.note_desc, 
                      n.text, n.read_only_access, n.private_access, n.insert_by, n.insert_date, n.update_by, n.update_date, 
                      n.delete_status
FROM         note AS n INNER JOIN
                      language AS l ON n.site_id = l.site_id

GO
grant select on comments_rs_view to OnyxPublic
GO

/****** Object:  View [dbo].[appointment_attendee_type_rs_view]    Script Date: 08/24/2009 06:30:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[appointment_attendee_type_rs_view]'))
DROP VIEW [dbo].[appointment_attendee_type_rs_view]
GO
/****** Object:  View [dbo].[appointment_attendee_type_rs_view]    Script Date: 08/24/2009 06:30:26 ******/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[appointment_attendee_type_rs_view]
AS
SELECT     attendee_type_code, name, site_id, language_code, record_status
FROM         dbo.appointment_attendee_type_ml_view AS aat


GO
grant select on appointment_attendee_type_rs_view to OnyxPublic
GO
/****** Object:  View [dbo].[email_priority_rs_view]    Script Date: 08/24/2009 06:28:48 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[email_priority_rs_view]'))
DROP VIEW [dbo].[email_priority_rs_view]
GO



/****** Object:  View [dbo].[email_priority_rs_view]    Script Date: 08/24/2009 06:28:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[email_priority_rs_view]
AS
SELECT DISTINCT 
                      em.priority AS ID, CASE WHEN priority = 1 THEN 'Low' WHEN priority = 2 THEN 'Normal' WHEN priority = 3 THEN 'High' END AS Priority, l.language_code, em.site_id, 
                      em.delete_status
FROM         dbo.email_message AS em INNER JOIN
                      dbo.language AS l ON em.site_id = l.site_id

GO

grant select on email_priority_rs_view to OnyxPublic
go

/****** Object:  View [dbo].[email_contact_type_rs_view]    Script Date: 08/24/2009 06:28:11 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[email_contact_type_rs_view]'))
DROP VIEW [dbo].[email_contact_type_rs_view]

/****** Object:  View [dbo].[email_contact_type_rs_view]    Script Date: 08/24/2009 06:28:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[email_contact_type_rs_view]
AS
SELECT DISTINCT email_contact_type_did, email_contact_type_name, site_id, language_code, record_status
FROM         dbo.email_contact_type_ml_view AS ect

GO
grant select on email_contact_type_rs_view to OnyxPublic
go

/****** Object:  View [dbo].[survey_qtype_rs_view]    Script Date: 08/24/2009 06:35:31 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[survey_qtype_rs_view]'))
DROP VIEW [dbo].[survey_qtype_rs_view]
GO


/****** Object:  View [dbo].[survey_qtype_rs_view]    Script Date: 08/24/2009 06:35:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[survey_qtype_rs_view]
AS
SELECT DISTINCT 
                      question_type_enum AS TypeID, 
                      CASE WHEN q.question_type_enum = 1 THEN 'Single' WHEN q.question_type_enum = 2 THEN 'Multiple' WHEN q.question_type_enum = 3 THEN 'Free Text' END AS Type,
                       site_id, language_code, record_status
FROM         dbo.question_ml_view AS q

GO

grant select on survey_qtype_rs_view to OnyxPublic
go