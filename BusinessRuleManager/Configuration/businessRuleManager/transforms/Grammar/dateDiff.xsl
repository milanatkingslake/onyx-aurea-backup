<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="dateDiff">
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="@description"/>
					Get the difference between 2 dates
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Date units = <span class="textLiteral">"<xsl:value-of select="part" />"</span>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					End date = <xsl:apply-templates select="left"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Start date = <xsl:apply-templates select="right"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
