// Copyright Aptean 2017. All rights reserved.

// This script can be used to execute a transaction using the Onyx Transaction Manager (OTM)

/*
** Constants
*/

// Create shell object
var shell = WScript.CreateObject("WScript.Shell")

// Load resource file
var resMgr = new ResourceManager(PATH_RESOURCE_FILE);

// Get config file path
var configPath = ScriptHost.getArgument(0);
if (configPath == "")
{
	shell.Popup(resMgr.getString("msg_MissingConfigPath"), 0, resMgr.getString("title"), 16);
	WScript.Quit();
}

// Load configuration file
var configDoc = XmlDocument.createFromFile(configPath);

// Get context properties
var appName = XmlDocument.getRequiredNodeValue(configDoc, "//context/appName");
var source = XmlDocument.getRequiredNodeValue(configDoc, "//context/source");
var siteId = XmlDocument.getRequiredNodeValue(configDoc, "//context/siteId");

var otm = new OTM(appName, source, siteId);

// Get authenticate method & authenticate
var authMethod = XmlDocument.getRequiredNodeValue(configDoc, "//authenticate/method");
switch (authMethod)
{
	case OTM.AUTH_METHOD_WINDOWS:
		otm.establishSessionWindows();
		break;
	case OTM.AUTH_METHOD_ONYX:
		var userId = XmlDocument.getRequiredNodeValue(configDoc, "//authenticate/userId");
		var pwd = XmlDocument.getRequiredNodeValue(configDoc, "//authenticate/password");
		otm.establishSessionOnyx(userId, pwd);
		break;
	default:
		shell.Popup(resMgr.getString("msg_InvalidAuthMethod"), 0, resMgr.getString("title"), 16);
		WScript.Quit();
}

// Get call parameters
var objectName = XmlDocument.getRequiredNodeValue(configDoc, "//otmCall/object");
var methodName = XmlDocument.getRequiredNodeValue(configDoc, "//otmCall/method");
var paramsNode = XmlDocument.getRequiredNode(configDoc, "//otmCall/parameters");

// Execute call
otm.execute(objectName, methodName, paramsNode.xml);

// Save results
var resultPath = XmlDocument.getRequiredNodeValue(configDoc, "//otmCall/resultPath");
otm.returnDoc.save(resultPath);

// Close Onyx session
otm.endSession();