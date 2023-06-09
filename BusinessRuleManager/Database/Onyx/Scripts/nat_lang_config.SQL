/* Copyright © Aptean 2014. All rights reserved. */
DECLARE @NAT_LANG_MSG_ID    INT
SET     @NAT_LANG_MSG_ID    = 775000

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The metadataFile additional data value does not have a value for this logical step.', N'sa', '20080116', N'sa', '20080116')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error loading the metadata file using the path: ''~0''', N'sa', '20080116', N'sa', '20080120')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Unknown class type mapped to grammar definition: ''~0''', N'sa', '20080117', N'sa', '20080120')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Undefined rule grammar: ''~0''', N'sa', '20080117', N'sa', '20080120')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The class ''~0'' does not implemented the required interface ''~1''.', N'sa', '20080117', N'sa', '20080117')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error creating instance of class ''~0''.', N'sa', '20080117', N'sa', '20080117')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The ''~1'' property for grammar ''~0'' has an invalid value: ''~2''.', N'sa', '20080120', N'sa', '20080120')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error convert literal value ''~1'' to data type ''~0''.', N'sa', '20080120', N'sa', '20080120')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The ''~0'' grammar expects ~1 child node(s).', N'sa', '20080120', N'sa', '20080124')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'A property or expression evaluates to an empty string value: ''~0''', N'sa', '20080124', N'sa', '20080124')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error accessing file: ''~0''', N'sa', '20080124', N'sa', '20080124')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'There are multiple files with the same name: ''~0''. Please specify the exact filename.', N'sa', '20080201', N'sa', '20080201')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error deleting file: ''~0''', N'sa', '20080201', N'sa', '20080201')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The file was not found or you do not have access: ''~0''', N'sa', '20080201', N'sa', '20080201')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'A file with the same name was found: ''~0''. Please specify a new name.', N'sa', '20080201', N'sa', '20080201')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'A ''~0'' grammar should have an ancestor ''~1'' grammar item.', N'sa', '20080206', N'sa', '20080206')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The folder was not found or you do not have access: ''~0''', N'sa', '20080207', N'sa', '20080207')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'A folder with the same name was found: ''~0''. Please specify a new name.', N'sa', '20080207', N'sa', '20080207')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error accessing folder: ''~0''', N'sa', '20080207', N'sa', '20080207')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error deleting folder: ''~0''', N'sa', '20080207', N'sa', '20080207')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error loading WSDL from the URL: ''~0''', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error parsing service description from WSDL: ''~0''', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Service name not found in WSDL: ''~0''', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'SOAP action not found for method ''~1'' in service ''~0''.', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error executing web service method ''~1'' for service named ''~0'' with WSDL ''~2''.', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Request URL not found for service ''~0''.', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error parsing response for web service method ''~0'' in service ''~1''.', N'sa', '20080310', N'sa', '20080310')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'The named ODBC connection was not found: ''~0''', N'sa', '20080530', N'sa', '20080530')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error opening named ODBC connection: ''~0''', N'sa', '20080530', N'sa', '20080530')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error executing ODBC statement: ''~0''', N'sa', '20080530', N'sa', '20080530')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Invalid ODBC data type: ''~0''', N'sa', '20080530', N'sa', '20080530')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Invalid ODBC parameter direction: ''~0''', N'sa', '20080530', N'sa', '20080530')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'A name or number must be provided to get the ODBC field value.', N'sa', '20080531', N'sa', '20080531')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Unsupported data type returned from ODBC query: ''~0''', N'sa', '20080531', N'sa', '20080531')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error formating string value: ''~0''', N'sa', '20080707', N'sa', '20080707')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Rule repository not found: ''~0''', N'sa', '20080414', N'sa', '20080414')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error parsing input XML.', N'sa', '20080414', N'sa', '20080414')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'A required input parameter was not found: ''~0''', N'sa', '20080414', N'sa', '20080414')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'~0 records were processed.', N'sa', '20080414', N'sa', '20080414')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error executing HTTP POST: ''~0'': ''~1''', N'sa', '20080414', N'sa', '20080414')

SET     @NAT_LANG_MSG_ID    = @NAT_LANG_MSG_ID + 1

INSERT INTO [nat_lang_config] ([message_code], [language_code], [site_id], [nat_lang_category_did], [message], [insert_by], [insert_date], [update_by], [update_date])
VALUES (@NAT_LANG_MSG_ID, N'ENG ', 1, 299, N'Error executing HTTP GET: ''~0'': ''~1''', N'sa', '20080414', N'sa', '20080414')
