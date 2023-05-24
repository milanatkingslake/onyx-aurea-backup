<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="encrypt">
		<table>
			<xsl:attribute name="class">
				tableRules <xsl:call-template name="active" />
			</xsl:attribute>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="@description"/>
					Encrypt a value
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Key = <xsl:apply-templates select="key"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Init Vector = <xsl:apply-templates select="vector"/>
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
