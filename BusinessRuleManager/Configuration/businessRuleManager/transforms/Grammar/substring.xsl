<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="substring">
		<table>
			<xsl:attribute name="class">
				tableRules <xsl:call-template name="active" />
			</xsl:attribute>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="@description"/>
					Substring
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Start = <xsl:apply-templates select="start"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Length = <xsl:apply-templates select="length"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					String value = <xsl:apply-templates select="value"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
