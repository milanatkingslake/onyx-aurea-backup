<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="replaceRegex">
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td class="cellContent">
					Regular expression replace
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Find string = <xsl:apply-templates select="find"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Replace with = <xsl:apply-templates select="replace"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Value = <xsl:apply-templates select="value"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
