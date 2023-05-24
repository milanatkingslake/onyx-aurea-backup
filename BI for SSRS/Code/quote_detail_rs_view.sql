/* **ONYX_COPYRIGHT_STRING** */
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
