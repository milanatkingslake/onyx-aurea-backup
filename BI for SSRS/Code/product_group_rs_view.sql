/* **ONYX_COPYRIGHT_STRING** */
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
