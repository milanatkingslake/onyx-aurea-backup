/* **ONYX_COPYRIGHT_STRING** */
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
            i.email_address,
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
            i.email_address,
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
