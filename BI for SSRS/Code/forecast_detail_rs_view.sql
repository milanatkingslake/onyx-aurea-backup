/* **ONYX_COPYRIGHT_STRING** */
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
