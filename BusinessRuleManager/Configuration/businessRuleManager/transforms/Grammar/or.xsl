<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="or">
		<xsl:apply-templates select="@description"/>
		<xsl:for-each select="*">
			<xsl:if test="position()!=1">
				<br/>
				OR
				<br/>
			</xsl:if>
			<xsl:text disable-output-escaping="yes">&amp;nbsp;&amp;nbsp;</xsl:text>(<xsl:apply-templates select="self::node()"/>)
		</xsl:for-each>
	</xsl:template>

</xsl:stylesheet>
