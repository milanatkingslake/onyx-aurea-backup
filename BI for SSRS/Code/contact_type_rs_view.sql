/* **ONYX_COPYRIGHT_STRING** */
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
