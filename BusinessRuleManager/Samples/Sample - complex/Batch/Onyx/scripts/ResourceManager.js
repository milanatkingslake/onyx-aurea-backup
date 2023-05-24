// Copyright © Aptean 2014. All rights reserved.

/*
** ResourceManager class
*/
function ResourceManager(pUrl)
{
	this.m_cache = XmlDocument.createFromFile(pUrl);
}

ResourceManager.prototype.getString = function(pResourceId)
{
	var resNode = this.m_cache.selectSingleNode("/strings/string[@id='" + pResourceId + "']/@value");
	if (!resNode)
	{
		return "*** " + pResourceId + " ***";
	}

	return resNode.text;
}
