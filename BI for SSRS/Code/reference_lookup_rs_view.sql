/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'reference_lookup_rs_view' AND type = N'v')
drop view reference_lookup_rs_view
go
CREATE VIEW reference_lookup_rs_view AS
     SELECT rl.reference_did,
            rl.reference_parameter_did,
            rl.parent_did,
            rl.site_id,
            rl.extra_data,
            rl.character_code,
            rl.seq_num,
            rf.reference_field_name,
            rf.parent_reference_field_did,
            rf.field_mask,
            rp.language_code,
            rp.parameter_desc,
            rl.insert_by,
            rl.insert_date,
            rl.update_by,
            rl.update_date,
            rl.onyx_timestamp
       FROM reference_lookup rl
       JOIN reference_field rf 
         ON rl.reference_did           = rf.reference_did
        AND rl.site_id                 = rf.site_id      
       JOIN reference_parameter_ml_view rp
         ON rl.reference_parameter_did = rp.reference_parameter_did
        AND rl.site_id                 = rp.site_id      
go
grant select on reference_lookup_rs_view to OnyxPublic
go
