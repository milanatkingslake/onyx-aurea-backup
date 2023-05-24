// Copyright © Aptean 2014. All rights reserved.

/*
** XmlDocument class
*/
function XmlDocument()
{
}

XmlDocument.create = function()
{
	var doc = new ActiveXObject("MSXML2.DOMDocument");
	doc.async = false;
	return doc;
}

XmlDocument.createFromFile = function(pUrl)
{
	var doc = XmlDocument.create();
	doc.load(pUrl);
	if (doc.parseError.errorCode != 0)
	{
		throw new Error(doc.parseError.errorCode, "Error loading resource file: " + pUrl +
			"\nReason:\t" + doc.parseError.reason);
	}
	return doc;
}

XmlDocument.createFromXml = function(pXmlString)
{
	var doc = XmlDocument.create();
	doc.loadXML(pXmlString);
	return doc;
}

XmlDocument.getRequiredNode = function(pXmlDoc, pXPath)
{
	var node = pXmlDoc.selectSingleNode(pXPath);
	if (!node)
	{
		throw new Error(doc.parseError.errorCode, "Require XML node not found: " + pXPath);
	}
	return node;
}

XmlDocument.getRequiredNodeValue = function(pXmlDoc, pXPath)
{
	return XmlDocument.getRequiredNode(pXmlDoc, pXPath).text;
}
