<?xml version="1.0" encoding="utf-8"?>
<!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="cacheDelete">
		<xsl:param name="position-prefix" select="string('')"/>
		<xsl:apply-templates select="@description"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:value-of select="concat($position-prefix,position())"/>: Delete a value from Application Cache:
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Name = <xsl:apply-templates select="name"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
