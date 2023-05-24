<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="concatenate">
		<xsl:apply-templates select="@description"/>
		Concatenate
		<xsl:for-each select="*">
			<xsl:if test="position()!=1">
				<br/>
				<xsl:text disable-output-escaping="yes">&amp;nbsp;&amp;nbsp;</xsl:text>with
			</xsl:if>
			(<xsl:apply-templates select="self::node()"/>)
		</xsl:for-each>
	</xsl:template>

</xsl:stylesheet>
