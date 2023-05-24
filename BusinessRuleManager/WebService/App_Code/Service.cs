// Copyright © Aptean 2014. All rights reserved.
using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

using ConsonaCRM.BusinessRuleManager;

[WebService(Namespace = "http://consonacrm.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service ()
	{
    }

    [WebMethod]
    public string Execute(string repositoryName, string metadataPath, string inputXml)
	{
		Engine engine = new Engine();
		string result = engine.Execute(repositoryName, metadataPath, inputXml);
		return result;
	}
}
