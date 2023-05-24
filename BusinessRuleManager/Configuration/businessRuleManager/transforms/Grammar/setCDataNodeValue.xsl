<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="setCDataNodeValue">
		<xsl:param name="position-prefix" select="string('')"/>
		<xsl:apply-templates select="@description"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:value-of select="concat($position-prefix,position())"/>: Set the value of a CData section:
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Path = <xsl:apply-templates select="path"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Value = <xsl:apply-templates select="value"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
