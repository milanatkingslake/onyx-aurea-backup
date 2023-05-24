/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'user_group_rs_view' AND type = N'v')
DROP VIEW user_group_rs_view
GO 

CREATE VIEW user_group_rs_view AS
     SELECT    group_code,
			   site_id,
			   language_code,

			   group_desc,
			   manager_id,
			   parent_user_group_code,

			   authority_id,
			   detail_access,
			   escalation_id,
			   email_alias,
			   insert_by,
			   insert_date,
			   update_by,
			   update_date,
			   onyx_timestamp,
			   record_status
from user_group_ml_view
go

GRANT SELECT ON user_group_rs_view TO OnyxPublic
GO
