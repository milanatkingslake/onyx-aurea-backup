/* **ONYX_COPYRIGHT_STRING** */
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
