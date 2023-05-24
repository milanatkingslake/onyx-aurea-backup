/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_ticket_association_rs_view' AND type = N'v')
DROP VIEW work_ticket_association_rs_view
GO 
create view work_ticket_association_rs_view
as	
    select w.work_ticket_association_id,
           w.site_id,
           l.language_code,
           w.work_ticket_id,
           w.associated_object_id,
           w.associated_object_type_enum,
           w.insert_by,
           w.insert_date,
           w.update_by,
           w.update_date,
           w.onyx_timestamp,
           w.delete_status
	from work_ticket_association w
	join language l
	   on w.site_id = l.site_id

	UNION

    select w.work_ticket_association_id,
           w.site_id,
           l.language_code,
           w.associated_object_id,  -- reversed to get the other worktickts that this one is linked to via reverse relationship
           w.work_ticket_id,
           w.associated_object_type_enum,
           w.insert_by,
           w.insert_date,
           w.update_by,
           w.update_date,
           w.onyx_timestamp,
           w.delete_status
	from work_ticket_association w
	join language l
	   on w.site_id = l.site_id
    where associated_object_type_enum = 10

    UNION

	select w.work_ticket_association_id,
			   w.site_id,
			   l.language_code,
			   w.work_ticket_id,
			   i.owner_id,
			   i.owner_type_enum,
			   w.insert_by,
			   w.insert_date,
			   w.update_by,
			   w.update_date,
			   w.onyx_timestamp,
			   w.delete_status
		from work_ticket_association w
        join incident i
          on i.incident_id = w.associated_object_id
		join language l
		   on w.site_id = l.site_id
           and l.site_id = i.site_id
go
grant select on work_ticket_association_rs_view to OnyxPublic
go


