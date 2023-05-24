<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="stopProcessing">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:value-of select="concat($position-prefix,position())"/>: Stop processing rules
					<xsl:apply-templates select="@description"/>
					<xsl:if test="return">
						<br/>
						and return <span class="textLiteral">"<xsl:value-of select="return"/>"</span>
					</xsl:if>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
