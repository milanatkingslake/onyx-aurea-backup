/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'product_header_rs_view' AND type = N'v')
DROP VIEW product_header_rs_view
GO 

CREATE VIEW product_header_rs_view AS
     SELECT ph.product_header_id,
            ph.site_id,
            l.language_code,
            ph.secondary_id,
            ph.owner_id,
            ph.owner_type_enum,
            ph.product_code,
            ph.primary_contact_id,
            ph.serial_number,
            ph.quantity,
            ph.purchase_date,
            ph.tracking_code_did,
            ph.source_did,
            ph.status_did,
            ph.read_only_access,
            ph.private_access,
            ph.insert_by,
            ph.insert_date,
            ph.update_by,
            ph.update_date,
            ph.onyx_timestamp,
            ph.delete_status,
            ph.user1,
            ph.user2,
            ph.user3,
            ph.user4,
            ph.user5,
            ph.user6,
            ph.user7,
            ph.user8,
            ph.user9,
            ph.user10
       FROM product_header ph
       JOIN Language l
         on l.site_id = ph.site_id

GO
GRANT SELECT ON product_header_rs_view TO OnyxPublic
GO

