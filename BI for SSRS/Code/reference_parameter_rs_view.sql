/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'reference_parameter_rs_view' AND type = N'v')
drop view reference_parameter_rs_view
go
CREATE VIEW reference_parameter_rs_view AS
     SELECT reference_parameter_did,
		   site_id,
		   language_code,
		   parameter_desc,
		   insert_by,
		   insert_date,
		   update_by,
		   update_date,
		   onyx_timestamp,
		   record_status
       FROM reference_parameter_ml_view
go
grant select on reference_parameter_rs_view to OnyxPublic
go

