/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'milestone_action_rs_view' AND type = N'v')
drop view milestone_action_rs_view
go
create view milestone_action_rs_view
as
select milestone_action_did,
       site_id,
       language_code,
       milestone_action_name,
       milestone_action_desc,
       insert_by,
       insert_date,
       update_by,
       update_date,
       onyx_timestamp,
       record_status
from milestone_action_ml_view
go
grant select on milestone_action_rs_view to OnyxPublic
go
