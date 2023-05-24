<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="copyFile">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: Copy a file on the file system
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Source file name = <xsl:apply-templates select="source"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Target file name = <xsl:apply-templates select="target"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
