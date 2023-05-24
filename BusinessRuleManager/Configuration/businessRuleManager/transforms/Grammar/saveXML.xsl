<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="saveXML">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: Save the contents of an XML node to a file
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					File name = <xsl:apply-templates select="name"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Path = <xsl:apply-templates select="path"/>
				</td>
			</tr>
			<xsl:if test="source">
				<tr>
					<td class="cellContent">
						Source document = <span class="textLiteral">"<xsl:apply-templates select="source"/>"</span>
					</td>
				</tr>
			</xsl:if>
		</table>
	</xsl:template>

</xsl:stylesheet>
