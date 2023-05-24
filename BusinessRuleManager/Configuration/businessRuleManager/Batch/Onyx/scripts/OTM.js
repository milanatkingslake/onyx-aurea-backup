// Copyright Aptean 2017. All rights reserved.


/*
** OTM class
*/
function OTM(pAppName, pSource, pSiteId)
{
	this.sessionId = "";
	this.appName = pAppName;
	this.source = pSource;
	this.siteId = pSiteId;
	this.returnDoc = null;
}

OTM.AUTH_METHOD_WINDOWS = "windows";
OTM.AUTH_METHOD_ONYX = "onyx";

OTM.prototype.establishSessionOnyx = function(pUserId, pPassword)
{
	var auth = new ActiveXObject("OnyxAuthenticate.AuthenticateOnyx");
	this.sessionId = auth.EstablishSession(pUserId, pPassword, this.appName, this.source, this.siteId);
}

OTM.prototype.establishSessionWindows = function()
{
	var auth = new ActiveXObject("OnyxAuthenticateNT.AuthenticateNT");
	this.sessionId = auth.EstablishSession(this.appName, this.source, this.siteId);
}

OTM.prototype.endSession = function()
{
	var sessionMgr = new ActiveXObject("OnyxSessionManager.Session");
	sessionMgr.EndSession(this.sessionId, this.appName);
	this.sessionId = "";
}

OTM.prototype.execute = function(pObject, pMethod, pParamsXml)
{
	var otm = new ActiveXObject("OnyxTransactionManager.TransactionManager");
	this.returnDoc = XmlDocument.createFromXml(otm.Execute(this.appName, pObject, pMethod, this.sessionId, pParamsXml));
}
