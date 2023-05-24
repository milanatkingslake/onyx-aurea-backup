<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="getSessionItem">
		<xsl:apply-templates select="@description"/>
		Get a named session variable
		(
		<xsl:apply-templates select="name" />
		)
	</xsl:template>

</xsl:stylesheet>
