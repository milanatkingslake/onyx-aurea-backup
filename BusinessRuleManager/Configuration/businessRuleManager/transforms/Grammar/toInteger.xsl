<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="toInteger">
		<xsl:apply-templates select="@description"/>
		Convert value to Integer (
		<xsl:apply-templates select="*" />
		)
	</xsl:template>

</xsl:stylesheet>
