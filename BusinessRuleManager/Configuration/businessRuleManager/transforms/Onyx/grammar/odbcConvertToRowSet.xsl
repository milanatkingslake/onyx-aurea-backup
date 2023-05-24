<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="odbcConvertToRowSet">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: Convert ODBC result set to Onyx rowSet
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Path = <xsl:apply-templates select="path"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					National language message ID = <xsl:apply-templates select="msgId"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
