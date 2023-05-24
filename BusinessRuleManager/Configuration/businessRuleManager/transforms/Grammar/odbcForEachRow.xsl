<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="odbcForEachRow">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: For Each ODBC result row
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="rules">
						<xsl:with-param name="position-prefix" select="concat($position-prefix,position(),'.')"/>
					</xsl:apply-templates>
				</td>
			</tr>
			<tr>
				<td>
					END For Each ODBC result row
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
