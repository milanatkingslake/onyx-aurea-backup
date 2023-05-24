<?xml version="1.0" encoding="utf-8"?>
<!-- Copyright © Aptean 2014. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:import href="grammar/@active.xsl"/>
	<xsl:import href="grammar/@description.xsl"/>

	<!--Base containers-->
	<xsl:import href="grammar/rules.xsl"/>
	<xsl:import href="grammar/rule.xsl"/>
	<xsl:import href="grammar/fieldMaps.xsl"/>
	<xsl:import href="grammar/literal.xsl"/>
	<xsl:import href="grammar/getNodeValue.xsl"/>
	<xsl:import href="grammar/getCDataNodeValue.xsl"/>
	<xsl:import href="grammar/getNodeXML.xsl"/>
	<xsl:import href="grammar/getNodeName.xsl"/>
	<xsl:import href="grammar/getNodeCount.xsl"/>

	<!--Process operations-->
	<xsl:import href="grammar/stopProcessing.xsl"/>
	<xsl:import href="grammar/if.xsl"/>
	<xsl:import href="grammar/while.xsl"/>
	<xsl:import href="grammar/usePath.xsl"/>
	<xsl:import href="grammar/forEach.xsl"/>
	<xsl:import href="grammar/addNode.xsl"/>
	<xsl:import href="grammar/copyNode.xsl"/>
	<xsl:import href="grammar/removeNodes.xsl"/>
	<xsl:import href="grammar/setNodeValue.xsl"/>
	<xsl:import href="grammar/setNodeXML.xsl"/>
	<xsl:import href="grammar/setCDataNodeValue.xsl"/>
	<xsl:import href="grammar/fieldMap.xsl"/>
	<xsl:import href="grammar/saveXML.xsl"/>
	<xsl:import href="grammar/rootPath.xsl"/>
	<xsl:import href="grammar/subProcess.xsl"/>
	<xsl:import href="grammar/webServiceCall.xsl"/>
	<xsl:import href="grammar/cacheRead.xsl"/>
	<xsl:import href="grammar/cacheWrite.xsl"/>
	<xsl:import href="grammar/cacheDelete.xsl"/>
	<xsl:import href="grammar/loopBreak.xsl"/>
	<xsl:import href="grammar/loopContinue.xsl"/>

	<!--File operations-->
	<xsl:import href="grammar/copyFile.xsl"/>
	<xsl:import href="grammar/deleteFile.xsl"/>
	<xsl:import href="grammar/fileExists.xsl"/>
	<xsl:import href="grammar/fileInfo.xsl"/>
	<xsl:import href="grammar/forEachFileInfo.xsl"/>
	<xsl:import href="grammar/fileInfoName.xsl"/>
	<xsl:import href="grammar/fileInfoPath.xsl"/>
	<xsl:import href="grammar/fileInfoSize.xsl"/>
	<xsl:import href="grammar/fileInfoCreateDate.xsl"/>
	<xsl:import href="grammar/fileInfoUpdateDate.xsl"/>
	<xsl:import href="grammar/fileInfoReadOnly.xsl"/>
	<xsl:import href="grammar/createFolder.xsl"/>
	<xsl:import href="grammar/deleteFolder.xsl"/>
	<xsl:import href="grammar/folderExists.xsl"/>
	<xsl:import href="grammar/folderInfo.xsl"/>
	<xsl:import href="grammar/forEachfolderInfo.xsl"/>
	<xsl:import href="grammar/folderInfoName.xsl"/>
	<xsl:import href="grammar/folderInfoPath.xsl"/>
	<xsl:import href="grammar/folderInfoCreateDate.xsl"/>
	<xsl:import href="grammar/folderInfoUpdateDate.xsl"/>

	<!--XML operations (return string)-->
	<xsl:import href="grammar/loadXML.xsl"/>
	<xsl:import href="grammar/xslt.xsl"/>

	<!--Boolean operations-->
	<xsl:import href="grammar/exists.xsl"/>
	<xsl:import href="grammar/not.xsl"/>
	<xsl:import href="grammar/and.xsl"/>
	<xsl:import href="grammar/or.xsl"/>

	<!--Date operations-->
	<xsl:import href="grammar/toDateTime.xsl"/>
	<xsl:import href="grammar/dateAdd.xsl"/>
	<xsl:import href="grammar/UTCToLocal.xsl"/>
	<xsl:import href="grammar/localToUTC.xsl"/>
	<xsl:import href="grammar/dateNow.xsl"/>
	<xsl:import href="grammar/dateNowUTC.xsl"/>
	<xsl:import href="grammar/dateEqualTo.xsl"/>
	<xsl:import href="grammar/dateLessThan.xsl"/>
	<xsl:import href="grammar/dateLessThanEqualTo.xsl"/>
	<xsl:import href="grammar/dateGreaterThan.xsl"/>
	<xsl:import href="grammar/dateGreaterThanEqualTo.xsl"/>
	<xsl:import href="grammar/datePart.xsl"/>
	<xsl:import href="grammar/dateDiff.xsl"/>
	<xsl:import href="grammar/startOfMinute.xsl"/>
	<xsl:import href="grammar/startOfHour.xsl"/>
	<xsl:import href="grammar/startOfDay.xsl"/>
	<xsl:import href="grammar/startOfWeek.xsl"/>
	<xsl:import href="grammar/startOfMonth.xsl"/>
	<xsl:import href="grammar/startOfYear.xsl"/>

	<!--String operations-->
	<xsl:import href="grammar/toString.xsl"/>
	<xsl:import href="grammar/upperCase.xsl"/>
	<xsl:import href="grammar/lowerCase.xsl"/>
	<xsl:import href="grammar/replaceText.xsl"/>
	<xsl:import href="grammar/replaceRegex.xsl"/>
	<xsl:import href="grammar/concatenate.xsl"/>
	<xsl:import href="grammar/stringEqualTo.xsl"/>
	<xsl:import href="grammar/stringGreaterThan.xsl"/>
	<xsl:import href="grammar/stringGreaterThanEqualTo.xsl"/>
	<xsl:import href="grammar/stringLessThan.xsl"/>
	<xsl:import href="grammar/stringLessThanEqualTo.xsl"/>
	<xsl:import href="grammar/stringLength.xsl"/>
	<xsl:import href="grammar/substring.xsl"/>
	<xsl:import href="grammar/newGuid.xsl"/>
	<xsl:import href="grammar/encrypt.xsl"/>
	<xsl:import href="grammar/decrypt.xsl"/>
	<xsl:import href="grammar/iif.xsl"/>
	<xsl:import href="grammar/forEachDelimitedString.xsl"/>
	<xsl:import href="grammar/delimitedString.xsl"/>
	<xsl:import href="grammar/stringFormat.xsl"/>

	<!--Integer operations-->
	<xsl:import href="grammar/toInteger.xsl"/>
	<xsl:import href="grammar/integerEqualTo.xsl"/>
	<xsl:import href="grammar/integerLessThan.xsl"/>
	<xsl:import href="grammar/integerLessThanEqualTo.xsl"/>
	<xsl:import href="grammar/integerGreaterThan.xsl"/>
	<xsl:import href="grammar/integerGreaterThanEqualTo.xsl"/>
	<xsl:import href="grammar/integerAdd.xsl"/>
	<xsl:import href="grammar/integerSubtract.xsl"/>
	<xsl:import href="grammar/integerMultiply.xsl"/>
	<xsl:import href="grammar/integerDivide.xsl"/>
	<xsl:import href="grammar/modulo.xsl"/>

	<!--Floating-point operations-->
	<xsl:import href="grammar/toFloat.xsl"/>
	<xsl:import href="grammar/floatEqualTo.xsl"/>
	<xsl:import href="grammar/floatLessThan.xsl"/>
	<xsl:import href="grammar/floatLessThanEqualTo.xsl"/>
	<xsl:import href="grammar/floatGreaterThan.xsl"/>
	<xsl:import href="grammar/floatGreaterThanEqualTo.xsl"/>
	<xsl:import href="grammar/floatAdd.xsl"/>
	<xsl:import href="grammar/floatSubtract.xsl"/>
	<xsl:import href="grammar/floatMultiply.xsl"/>
	<xsl:import href="grammar/floatDivide.xsl"/>
	<xsl:import href="grammar/floor.xsl"/>
	<xsl:import href="grammar/ceiling.xsl"/>
	<xsl:import href="grammar/round.xsl"/>

	<!--Data operations-->
	<xsl:import href="grammar/odbcConnection.xsl"/>
	<xsl:import href="grammar/odbcCall.xsl"/>
	<xsl:import href="grammar/odbcAddParameter.xsl"/>
	<xsl:import href="grammar/odbcParameterValue.xsl"/>
	<xsl:import href="grammar/odbcFieldValue.xsl"/>
	<xsl:import href="grammar/odbcColumnCount.xsl"/>
	<xsl:import href="grammar/odbcRowCount.xsl"/>
	<xsl:import href="grammar/odbcForEachRow.xsl"/>

	<xsl:output method="html" omit-xml-declaration="yes" />

</xsl:stylesheet>
