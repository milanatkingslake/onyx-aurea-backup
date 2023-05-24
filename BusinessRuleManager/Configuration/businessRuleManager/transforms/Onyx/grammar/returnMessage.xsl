<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="returnMessage">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>:
					Return an Onyx
					<xsl:choose>
						<xsl:when test="type[.='error']">
							Error
						</xsl:when>
						<xsl:when test="type[.='error']">
							Warning
						</xsl:when>
						<xsl:otherwise>
							Informational Message
						</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					using message ID:
					<span class="textLiteral">"<xsl:value-of select="msgId"/>"</span>
					<xsl:if test="arguments[.!='']">
						<br/>
						with the argument(s):
						<xsl:apply-templates select="arguments"/>
					</xsl:if>
				</td>
			</tr>
		</table>
	</xsl:template>
	
</xsl:stylesheet>
