<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="subProcess">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="@description"/>
					Process another rule set
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					File name = <xsl:apply-templates select="name"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
