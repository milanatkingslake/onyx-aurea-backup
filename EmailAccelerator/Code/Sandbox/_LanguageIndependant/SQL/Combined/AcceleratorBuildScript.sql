/*
** Tables
*/
CREATE TABLE mass_email_history(
             mass_email_batch_id                     UNIQUEIDENTIFIER  NOT NULL,
             individual_id                           UNIQUEIDENTIFIER  NOT NULL,
             tracking_code_did                       INT               NULL,
             sent_date                               DATETIME          NULL)
GO

CREATE TABLE mass_email_queue(
             mass_email_batch_id                     UNIQUEIDENTIFIER  NOT NULL,
             individual_id                           UNIQUEIDENTIFIER  NOT NULL,
             insert_date                             DATETIME          NULL)
GO

CREATE TABLE mass_email_invalid_records(
             mass_email_batch_id                     UNIQUEIDENTIFIER  NOT NULL,
             individual_id                           UNIQUEIDENTIFIER  NOT NULL,
             insert_date                             DATETIME          NULL)
GO

CREATE TABLE mass_email_batch(
             mass_email_batch_id                     UNIQUEIDENTIFIER  NOT NULL,
             batch_query                             NTEXT             NOT NULL,
             insert_by                               NVARCHAR(85)      NOT NULL,
             insert_date                             DATETIME          NOT NULL)
GO




/*
** Indexes
*/
CREATE INDEX mass_email_history_batch_indiv_idx
   ON mass_email_history (individual_id, mass_email_batch_id)
GO

CREATE INDEX mass_email_queue_batch_indiv_idx
   ON mass_email_queue (individual_id, mass_email_batch_id)
GO

CREATE INDEX mass_email_batch_idx
   ON mass_email_batch (mass_email_batch_id)
GO





/*
** Procedures
*/
IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcgDecryptEmailData')
    DROP PROCEDURE SDpcgDecryptEmailData
GO 

CREATE PROCEDURE SDpcgDecryptEmailData
(
   @encoded_string         VARCHAR(100),
   @intact                 TINYINT           OUTPUT,
   @individual_id          UNIQUEIDENTIFIER  OUTPUT,
   @tracking_code_did      INT               OUTPUT,
   @milestone_action_did   INT               OUTPUT
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This stored procedure decodes a string and returns the individual id,
**          tracking code id, and action id.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   DECLARE @temp_encoded           VARCHAR(100),
           @individual_id_string1  VARCHAR(4),
           @individual_id_string2  VARCHAR(14),
           @individual_id_string3  VARCHAR(18),
           @dash_position          INT   


   SET @temp_encoded          = @encoded_string
   SET @individual_id_string1 = SUBSTRING(@temp_encoded, 1, 4)

   SET @temp_encoded          = SUBSTRING(@temp_encoded, 6, LEN(@temp_encoded) - 3)
   SET @dash_position         = CHARINDEX('-', @temp_encoded)
   SET @tracking_code_did     = SUBSTRING(@temp_encoded, 1, @dash_position - 1)

   SET @temp_encoded          = SUBSTRING(@temp_encoded, @dash_position, LEN(@temp_encoded) - @dash_position + 1)
   SET @individual_id_string3 = SUBSTRING(@temp_encoded, 1, 18)

   SET @temp_encoded          = SUBSTRING(@temp_encoded, 20, LEN(@temp_encoded) - 19)
   SET @dash_position         = CHARINDEX('-', @temp_encoded)
   SET @milestone_action_did  = SUBSTRING(@temp_encoded, 1, @dash_position - 1)

   SET @temp_encoded          = SUBSTRING(@temp_encoded, @dash_position + 1, LEN(@temp_encoded) - @dash_position + 1)
   SET @individual_id_string2 = SUBSTRING(@temp_encoded, 1, 14)

   SET @individual_id         = @individual_id_string1 + @individual_id_string2 + @individual_id_string3

   SET @intact = 1
   
END
GO

GRANT EXEC ON SDpcgDecryptEmailData TO OnyxPublic 
GO



IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcgEncryptEmailData')
    DROP PROCEDURE SDpcgEncryptEmailData
GO 

CREATE PROCEDURE SDpcgEncryptEmailData
(
   @site_id                       INT,
   @individual_id                 UNIQUEIDENTIFIER,
   @view_tracking_code_did        INT,
   @view_milestone_action_did     INT,
   @opt_out_tracking_code_did     INT,
   @opt_out_milestone_action_did  INT,
   @view_encoded                  NVARCHAR(100)     OUTPUT,
   @optout_encoded                NVARCHAR(100)     OUTPUT, 
   @email_address                 NVARCHAR(255)     OUTPUT,
   @first_name                    NVARCHAR(255)     OUTPUT,
   @last_name                     NVARCHAR(255)     OUTPUT,
   @company_name                  NVARCHAR(255)     OUTPUT
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This stored procedure encodes an individual id,
**          tracking code id, and action id for viewed and opt-out actions.
**          It also returns the first name, last name, and company name
**          for mail merge functionality.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN
   
   DECLARE @individual_id_string   VARCHAR(36)

   SET @individual_id_string = CONVERT(VARCHAR(36),@individual_id)
   

   SET @view_encoded = SUBSTRING(@individual_id_string, 1, 4)
   SET @view_encoded = @view_encoded + '-' + CONVERT(VARCHAR, @view_tracking_code_did)
   SET @view_encoded = @view_encoded + SUBSTRING(@individual_id_string, 19, 18)
   SET @view_encoded = @view_encoded + '-' + CONVERT(VARCHAR, @view_milestone_action_did) + '-'
   SET @view_encoded = @view_encoded + SUBSTRING(@individual_id_string, 5, 14)


   SET @optout_encoded = SUBSTRING(@individual_id_string, 1, 4)
   SET @optout_encoded = @optout_encoded + '-' + CONVERT(VARCHAR, @opt_out_tracking_code_did)
   SET @optout_encoded = @optout_encoded + SUBSTRING(@individual_id_string, 19, 18)
   SET @optout_encoded = @optout_encoded + '-' + CONVERT(VARCHAR, @opt_out_milestone_action_did) + '-'
   SET @optout_encoded = @optout_encoded + SUBSTRING(@individual_id_string, 5, 14)


   SELECT @email_address = email_address, 
          @first_name    = first_name, 
          @last_name     = last_name, 
          @company_name  = company_name 
     FROM individual
    WHERE individual_id = @individual_id 
      AND site_id       = @site_id 
      AND delete_status = 0

END
GO

GRANT EXEC ON SDpcgEncryptEmailData TO OnyxPublic 
GO




IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcgGetEmailQueue')
    DROP PROCEDURE SDpcgGetEmailQueue
GO 

CREATE PROCEDURE SDpcgGetEmailQueue
(
   @site_id                       INT,
   @mass_email_batch_id           UNIQUEIDENTIFIER
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This stored procedure queries mass_email_queue to return all 
**          recipients for the batch email to be sent.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   
   SELECT DISTINCT q.individual_id 
     FROM mass_email_queue q
    WHERE q.mass_email_batch_id = @mass_email_batch_id 
      AND EXISTS (SELECT 1 
                    FROM individual i
                   WHERE q.individual_id   = i.individual_id 
                     AND i.email_address   IS NOT NULL 
                     AND i.email_address   <> '' 
                     AND i.email_address   <> ' ' 
                     AND i.site_id         = @site_id 
                     AND i.delete_status   = 0)
                     AND NOT EXISTS (SELECT 1 
                                       FROM mass_email_history h 
                                      WHERE h.individual_id       = q.individual_id  
                                        AND h.mass_email_batch_id = @mass_email_batch_id)
END
GO

GRANT EXEC ON SDpcgGetEmailQueue TO OnyxPublic
GO
 

IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcgValidateEmailQueue')
    DROP PROCEDURE SDpcgValidateEmailQueue
GO 

CREATE PROCEDURE SDpcgValidateEmailQueue
(
   @site_id                       INT,
   @mass_email_batch_id           UNIQUEIDENTIFIER
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This sproc validates a mass_email_batch_id against mass_email_queue.
**          The first three recipients for the batch email to be sent will be returned.
**          A return code of -1 will be returned if @mass_email_batch_id is invalid.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   DECLARE @return_code    INT,
           @batch_count    INT
                           
   SET     @return_code    = 0
   SET     @batch_count    = 0



   SELECT @batch_count = count(*)
     FROM (SELECT DISTINCT q.individual_id
             FROM mass_email_queue q 
            WHERE q.mass_email_batch_id = @mass_email_batch_id 
              AND NOT EXISTS (SELECT 1 
                                FROM mass_email_history h
                               WHERE h.individual_id       = q.individual_id 
                                 AND h.mass_email_batch_id = @mass_email_batch_id)) a
   
   
   IF @batch_count = 0 
   BEGIN
       SET @return_code = -1
   END
   ELSE
   BEGIN
      SET ROWCOUNT 3
      SELECT @batch_count as batchCount, 
             i.first_name, 
             i.last_name 
        FROM individual i
        JOIN mass_email_queue q 
          ON i.individual_id = q.individual_id
       WHERE q.mass_email_batch_id = @mass_email_batch_id 
         AND NOT EXISTS (SELECT 1 
                           FROM mass_email_history h
                          WHERE h.individual_id       = q.individual_id 
                            AND h.mass_email_batch_id = @mass_email_batch_id)
   END
   
   RETURN @return_code

END
GO

GRANT EXEC ON SDpcgValidateEmailQueue TO OnyxPublic
GO





IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcuSentEmail')
    DROP PROCEDURE SDpcuSentEmail
GO 

CREATE PROCEDURE SDpcuSentEmail
(
   @mass_email_batch_id           UNIQUEIDENTIFIER,
   @tracking_code_did             INT,
   @individual_id                 UNIQUEIDENTIFIER
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This sproc inserts records from the mass_email_queue table to
**          the mass_email_history table.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   INSERT 
     INTO mass_email_history(
          mass_email_batch_id,
          individual_id,
          tracking_code_did,
          sent_date)
   SELECT @mass_email_batch_id, 
          @individual_id, 
          @tracking_code_did, 
          getutcdate()

END
GO

GRANT EXEC ON SDpcuSentEmail TO OnyxPublic
GO






IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcdProcessedEmail')
    DROP PROCEDURE SDpcdProcessedEmail
GO 

CREATE PROCEDURE SDpcdProcessedEmail
(
   @mass_email_batch_id           UNIQUEIDENTIFIER
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This sproc deletes sent records from the mass_email_queue table to 
**          the mass_email_history table.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   INSERT 
     INTO mass_email_invalid_records(
          mass_email_batch_id,
          individual_id,
          insert_date)        
   SELECT q.mass_email_batch_id,
          q.individual_id,
          getutcdate() 
     FROM mass_email_queue q 
    WHERE q.mass_email_batch_id = @mass_email_batch_id 
      AND NOT EXISTS (SELECT 1 
                        FROM mass_email_history h
                       WHERE h.individual_id = q.individual_id 
                         AND h.mass_email_batch_id = @mass_email_batch_id)
   
   DELETE 
     FROM mass_email_queue
    WHERE mass_email_batch_id = @mass_email_batch_id 
   
   
END   
GO

GRANT EXEC ON SDpcdProcessedEmail TO OnyxPublic
GO
 
 




IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpsiCampaign')
    DROP PROCEDURE SDpsiCampaign
GO 

CREATE PROCEDURE SDpsiCampaign
(
   @site_id                       INT,
   @owner_id                      UNIQUEIDENTIFIER,
   @tracking_code_did             INT,
   @milestone_action_did          INT
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This sproc links an individual to a mass email campaign 
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/08/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   DECLARE @return_code                INT,
           @message_code               INT,
           @message_parameter          NVARCHAR(255),
           @error                      INT,
           @secondary_id               INT,
           @owner_campaign_id          UNIQUEIDENTIFIER,
           @owner_campaign_detail_id   UNIQUEIDENTIFIER,
           @current_date               DATETIME 


   SET     @return_code                = 0
   SET     @current_date               = getutcdate()
   SET     @owner_campaign_detail_id   = newid() 


   BEGIN TRANSACTION



   SELECT @owner_campaign_id = owner_campaign_id
     FROM owner_campaign
    WHERE tracking_code_did = @tracking_code_did
      AND owner_id          = @owner_id
      AND site_id           = @site_id
      AND delete_status     = 0

   IF @owner_campaign_id IS NOT NULL
   BEGIN
      UPDATE owner_campaign
         SET update_by         = N'sa',
             update_date       = @current_date
       WHERE owner_campaign_id = @owner_campaign_id
   END
   ELSE
   BEGIN
      SET @owner_campaign_id = newid() 

      IF @return_code <= 0		
      BEGIN
         EXEC @return_code = opOwnerCampaignGetSecondaryId @message_code      OUTPUT, 
                                                           @message_parameter OUTPUT, 
                                                           @error             OUTPUT, 
                                                           @secondary_id      OUTPUT
         SELECT @error = @@ERROR
            
         IF @error != 0 SET @return_code = 1
      END
   					
   
      IF @owner_id IS NULL OR NOT EXISTS (SELECT 1
                                            FROM individual WITH(ROWLOCK, UPDLOCK)
                                           WHERE individual_id = @owner_id
       			                              AND delete_status = 0)
      BEGIN
         SET @return_code = 2
         SET @message_code = 737054
         SET @message_parameter = N'ownerId'
      END
   					
      IF @return_code <= 0
      BEGIN
         INSERT INTO owner_campaign (
                     owner_campaign_id,
                     secondary_id,
                     owner_id,
                     owner_type_enum,
                     tracking_code_did,
                     read_only_access,
                     private_access,
                     site_id,
                     insert_by,
                     insert_date,
                     update_by,
                     update_date,
                     delete_status)
              VALUES (@owner_campaign_id,
                      @secondary_id,
                      @owner_id,
                      1,
                      @tracking_code_did, 
                      0,               
                      0,               
                      @site_id,
                      N'sa',            
                      @current_date, 
                      N'sa',
                      @current_date,
                      0)
   
   
            SELECT @error = @@ERROR
            
            IF @error != 0 SET @return_code = 1
   
      END

   END
 

   IF @return_code <= 0
   BEGIN
      IF EXISTS (SELECT 1 
                   FROM owner_campaign_detail 
                  WHERE owner_campaign_id    = @owner_campaign_id 
                    AND milestone_action_did = @milestone_action_did 
                    AND delete_status        = 0)
      BEGIN
         UPDATE owner_campaign_detail 
            SET action_date = @current_date
          WHERE owner_campaign_id    = @owner_campaign_id 
            AND milestone_action_did = @milestone_action_did 
            AND delete_status        = 0
      END
      ELSE
      BEGIN
         IF @milestone_action_did IS NOT NULL
         BEGIN
            INSERT INTO owner_campaign_detail (
                        owner_campaign_detail_id,
                        owner_campaign_id,
                        milestone_action_did,
                        action_date,
                        site_id,
                        insert_by,
                        insert_date,
                        update_by,
                        update_date,
                        delete_status)
                 VALUES (@owner_campaign_detail_id,
                         @owner_campaign_id,
                         @milestone_action_did,
                         @current_date,
                         @site_id,
                         N'sa',            
                         @current_date, 
                         N'sa',
                         @current_date,
                         0)
      
         END
      END
   END

   IF @return_code <= 0
   BEGIN
      COMMIT TRANSACTION
   END
   ELSE 
   BEGIN
      ROLLBACK TRANSACTION      
   END
   
   RETURN @return_code
   
END
GO

GRANT EXEC ON SDpsiCampaign TO OnyxPublic
GO


  
IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcdEmailBatchInsert')
    DROP PROCEDURE SDpcdEmailBatchInsert
GO 

CREATE PROCEDURE SDpcdEmailBatchInsert
(
   @mass_email_batch_id           UNIQUEIDENTIFIER,
   @mass_email_batch_query        NTEXT,
   @insert_by                     NVARCHAR(85)
) 
WITH EXECUTE AS SELF
AS
/*
** Purpose: This sproc creates a record containing the email batch query 
**          that will be executed.
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/23/2006  RobC     Created for Email Accelerator port.
**  @Rm--
**
*/
BEGIN

   DECLARE @return_code        INT,
           @insert_date        DATETIME,
           @error              INT

   SET     @return_code        = 0
   SET     @insert_date        = getutcdate()

   BEGIN TRANSACTION

   INSERT 
     INTO mass_email_batch(
          mass_email_batch_id,
          batch_query,
          insert_by,
          insert_date)        
   VALUES(@mass_email_batch_id,
          @mass_email_batch_query,
          @insert_by,
          @insert_date)
   
   SELECT @error = @@ERROR
   IF @error != 0 SET @return_code = 1

   IF @return_code <= 0
   BEGIN
      COMMIT TRANSACTION
   END
   ELSE 
   BEGIN
      ROLLBACK TRANSACTION      
   END
   
   RETURN @return_code
   
END   
GO

GRANT EXEC ON SDpcdEmailBatchInsert TO OnyxPublic
GO
 



IF EXISTS  (SELECT * FROM sysobjects
            WHERE name = N'SDpcdEmailBatchExecute')
    DROP PROCEDURE SDpcdEmailBatchExecute
GO 

CREATE PROCEDURE SDpcdEmailBatchExecute
(
   @mass_email_batch_id           UNIQUEIDENTIFIER
) 
WITH EXECUTE AS $(ONYXLM_LOGIN)
AS
/*
**  Purpose: This procedure will execute the sql query identified by 
**           @mass_email_batch_id. 
**
**  @Rm++
**  Revision History
**  -------------------------------------------------------------------------
**  Date        Name     Description
**  -------------------------------------------------------------------------
**  03/23/2006  RobC     Created for Email Accelerator port.
**  @Rm--
*/
BEGIN

   DECLARE @return_code      INT,
           @error            INT,
           @query_text       NVARCHAR(MAX)

   SET     @return_code      = 0
   

   SELECT @query_text = batch_query 
     FROM mass_email_batch
    WHERE mass_email_batch_id = @mass_email_batch_id


   EXEC @return_code = sp_ExecuteSQL @query_text
   
   SET @error = @@error
   IF @error <> 0 SET @return_code = 1   

             
   RETURN @return_code

END
GO 
GRANT EXECUTE ON SDpcdEmailBatchExecute TO OnyxPublic
GO 

