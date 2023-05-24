<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="odbcAddParameter">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: Add an ODBC parameter:
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Name = <xsl:apply-templates select="name"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Type = <xsl:apply-templates select="type"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Direction = <xsl:apply-templates select="direction"/>
				</td>
			</tr>
			<xsl:if test="value">
			<tr>
				<td class="cellContent">
					Value = <xsl:apply-templates select="value"/>
				</td>
			</tr>
			</xsl:if>
		</table>
	</xsl:template>

</xsl:stylesheet>
