/* **ONYX_COPYRIGHT_STRING** */
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




