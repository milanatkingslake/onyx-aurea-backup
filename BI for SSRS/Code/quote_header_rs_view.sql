/* **ONYX_COPYRIGHT_STRING** */
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

