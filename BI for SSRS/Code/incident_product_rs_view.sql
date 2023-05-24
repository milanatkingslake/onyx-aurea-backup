/* **ONYX_COPYRIGHT_STRING** */
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



