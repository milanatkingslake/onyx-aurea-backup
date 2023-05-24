<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="stringFormat">
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td class="cellContent">
					Format a string value:
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Format string = <xsl:apply-templates select="value"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					Arguments = <xsl:apply-templates select="replace"/>
					<xsl:for-each select="arguments/*">
						<xsl:if test="position()!=1">
							<br/>
							,<xsl:text disable-output-escaping="yes">&amp;nbsp;&amp;nbsp;</xsl:text>
						</xsl:if>
						(<xsl:apply-templates select="self::node()"/>)
					</xsl:for-each>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
