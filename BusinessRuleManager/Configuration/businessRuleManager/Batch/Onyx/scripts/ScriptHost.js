// Copyright Aptean 2017. All rights reserved.

/*
** ScriptHost class
*/
function ScriptHost()
{
}

ScriptHost.getArgument = function(pIndex)
{
	var args = WScript.Arguments;
	if (args.Length <= pIndex)
	{
		return "";
	}
	return args.Item(pIndex);
}
