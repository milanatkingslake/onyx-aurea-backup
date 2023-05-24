/* **ONYX_COPYRIGHT_STRING** */
IF EXISTS (SELECT * FROM sysobjects 
            WHERE name = N'work_note_rs_view' AND type = N'v')
drop view work_note_rs_view
go
create view work_note_rs_view
as
	Select work_note_detail_id,
			h.work_note_header_id,
            h.owner_id,
            l.language_code,
			h.site_id,
			seq_num,
			logmark,
			logmark_sequence,
			publish_bit_mask,
			convert(nvarchar(4000), work_note)  as  work_note,
			d.insert_by,
			d.insert_date,
			d.update_by,
			d.update_date,
			d.onyx_timestamp
	from work_note_detail d
    join language l
      on l.site_id = d.site_id
    join work_note_header h
      on d.work_note_header_id = h.work_note_header_id
      and h.delete_status = 0 
    where d.delete_status = 0

go
grant select on work_note_rs_view to OnyxPublic
go

