<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="datePart">
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="@description"/>
					Get part of a date/time value
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Date interval = <span class="textLiteral">"<xsl:value-of select="part" />"</span>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Date value = <xsl:apply-templates select="value"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
