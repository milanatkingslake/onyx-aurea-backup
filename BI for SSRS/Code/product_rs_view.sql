/* **ONYX_COPYRIGHT_STRING** */
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

