/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'users_rs_view' AND type = N'v')
DROP VIEW users_rs_view
GO 

/*
** ObjectName: users_rs_view
**
** Description:
**
** Revision History:
** ----------------------------------------------------------------------------
**  Date        Name        Description
** ----------------------------------------------------------------------------
*/
CREATE VIEW users_rs_view AS
     SELECT u.user_id,
            u.site_id,
            l.language_code,
            u.user_name,
            u.email_alias,
            network_user = (select min(network_user) from network_user n where n.user_id = u.user_id and n.site_id = u.site_id),
            
	        u.manager_id,
            u.group_code,
            
            u.authority_id,
            u.detail_add,
            u.detail_delete,
            u.detail_view,
            u.security_id,
            u.language_code as user_language_code,
            u.computer_name,
            u.last_login_date,
            u.password,
            u.allow_auth_types,
            u.allow_impersonate,
            u.insert_by,
            u.insert_date,
            u.update_by,
            u.update_date,
            u.record_status,
            l.language_code             AS ml_language_code,
            u.onyx_timestamp
       FROM users u
       JOIN language l
         ON u.site_id       = l.site_id
GO

GRANT SELECT ON users_rs_view TO OnyxPublic
GO
