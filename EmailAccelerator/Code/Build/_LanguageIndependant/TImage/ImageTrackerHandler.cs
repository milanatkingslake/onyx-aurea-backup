// **ONYX_COPYRIGHT_STRING**
using System;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Configuration;


namespace ImageTrackerHandler
{
	/// <summary>
	/// 
	/// </summary>
	public class ImageHandler : IHttpHandler
	{
		private string dbConnectionString = "";

		public ImageHandler(){}

		#region Implementation of IHttpHandler
		public void ProcessRequest(System.Web.HttpContext context)
		{
			try
			{
				HttpResponse objResponse = context.Response;
				HttpRequest objRequest = context.Request;
				string url = objRequest.Path;
				string requestKey;
				int lastSlashPos = url.LastIndexOf("/");
				int fileExtensionLen = ".gif".Length + 1;
				string imageFile = ConfigurationManager.AppSettings["GIF_FILE"];

				// The key is the file name, which we extract between the last / and the .gif
				requestKey = url.Substring(lastSlashPos + 1, url.Length - lastSlashPos - fileExtensionLen);
				
				SaveToDatabase(requestKey);
				
				// Send back to the client the gif file specified in the config file
				objResponse.ContentType = "image/gif";
				objResponse.WriteFile(objRequest.MapPath(imageFile));
				objResponse.End();
			}
			catch (System.Threading.ThreadAbortException ex)
			{
				//Response.End (by design, I believe) throws this exception to end the page call.  For mor information view the URL below.
				//http://web.archive.org/web/20040214015315/http://p2p.wrox.com/topic.asp?TOPIC_ID=5989
			}
			catch (Exception e)
			{
				//If something goes wrong, try to send something to the client
				HttpResponse objFailedResponse = context.Response;
				objFailedResponse.ContentType = "image/gif";
				objFailedResponse.End();
				return;
			}
		}

		public bool IsReusable
		{
			get
			{
				return true;
			}
		}
		#endregion

		private void SaveToDatabase(string key)
		{
			try 
			{
				if ( ( key==null) || ( key.Trim().Length == 0 ) )
					return;

                int siteID = Convert.ToInt32(ConfigurationManager.AppSettings["SITEID"]);
                dbConnectionString = ConfigurationManager.AppSettings["DBCONN_STRING"];
				SqlConnection dbConn = new SqlConnection(dbConnectionString);

				// Test string for decoding:  4081026I12065F749S263
				dbConn.Open();
				SqlCommand dbCommand = dbConn.CreateCommand();
				dbCommand.CommandType = CommandType.StoredProcedure;
				dbCommand.CommandText = "SDpcgDecryptEmailData";
				dbCommand.Parameters.Add("@encoded_string", SqlDbType.VarChar, 100);
				dbCommand.Parameters.Add("@intact", SqlDbType.TinyInt);
				dbCommand.Parameters.Add("@individual_id", SqlDbType.UniqueIdentifier);
				dbCommand.Parameters.Add("@tracking_code_did", SqlDbType.Int);
				dbCommand.Parameters.Add("@milestone_action_did", SqlDbType.Int);

				dbCommand.Parameters["@encoded_string"].Direction = ParameterDirection.Input;
				dbCommand.Parameters["@encoded_string"].Value = key;
				dbCommand.Parameters["@intact"].Direction = ParameterDirection.Output;
				dbCommand.Parameters["@individual_id"].Direction = ParameterDirection.Output;
				dbCommand.Parameters["@tracking_code_did"].Direction = ParameterDirection.Output;
				dbCommand.Parameters["@milestone_action_did"].Direction = ParameterDirection.Output;

				dbCommand.ExecuteNonQuery();
				
				int isResultIntact = 0;
				Guid userID;
				int trackingID = 0;
				int actionID = 0;
				
				isResultIntact = Convert.ToInt32(dbCommand.Parameters["@intact"].Value);
				userID = (Guid) dbCommand.Parameters["@individual_id"].Value;
				trackingID = Convert.ToInt32(dbCommand.Parameters["@tracking_code_did"].Value);
				actionID = Convert.ToInt32(dbCommand.Parameters["@milestone_action_did"].Value);

				if ((trackingID > 0) && (actionID > 0) && (isResultIntact == 1))
				{
					//The decode attempt was a success, save the data to OnyxCRM.

					dbCommand.Parameters.Clear();
					dbCommand.CommandType = CommandType.StoredProcedure;
					dbCommand.CommandText = "SDpsiCampaign";
					dbCommand.Parameters.Add("@site_id", SqlDbType.Int);
					dbCommand.Parameters.Add("@owner_id", SqlDbType.UniqueIdentifier);
					dbCommand.Parameters.Add("@tracking_code_did", SqlDbType.Int);
					dbCommand.Parameters.Add("@milestone_action_did", SqlDbType.Int);

					dbCommand.Parameters["@owner_id"].Direction = ParameterDirection.Input;
					dbCommand.Parameters["@tracking_code_did"].Direction = ParameterDirection.Input;
					dbCommand.Parameters["@milestone_action_did"].Direction = ParameterDirection.Input;
					dbCommand.Parameters["@site_id"].Direction = ParameterDirection.Input;

					dbCommand.Parameters["@owner_id"].Value = userID;
					dbCommand.Parameters["@tracking_code_did"].Value = trackingID;
					dbCommand.Parameters["@milestone_action_did"].Value = actionID;
					dbCommand.Parameters["@site_id"].Value = siteID;

					dbCommand.ExecuteNonQuery();
				}

				dbConn.Close();
			}
			catch
			{
				return;
			}
		}
	}

}
