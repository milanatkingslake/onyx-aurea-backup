<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="if">
		<xsl:param name="position-prefix" select="string('')"/>
		<table cellspacing="0">
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: IF
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="test" />
				</td>
			</tr>
			<tr>
				<td>
					<xsl:apply-templates select="then">
						<xsl:with-param name="position-prefix" select="concat($position-prefix,position(),'.')"/>
					</xsl:apply-templates>
					<xsl:apply-templates select="else">
						<xsl:with-param name="position-prefix" select="concat($position-prefix,position(),'.')"/>
					</xsl:apply-templates>
				</td>
			</tr>
			<tr>
				<td>
					END IF
				</td>
			</tr>
		</table>
	</xsl:template>

	<xsl:template match="test[parent::node()[name()='if']]">
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td>
					<xsl:apply-templates select="*" />
				</td>
			</tr>
		</table>
	</xsl:template>

	<xsl:template match="then[parent::node()[name()='if']]">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					THEN
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="*">
						<xsl:with-param name="position-prefix" select="$position-prefix"/>
					</xsl:apply-templates>
				</td>
			</tr>
		</table>
	</xsl:template>

	<xsl:template match="else[parent::node()[name()='if']]">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">
				tableRules <xsl:call-template name="active" />
			</xsl:attribute>
			<tr>
				<td>
					ELSE
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="*">
						<xsl:with-param name="position-prefix" select="$position-prefix"/>
					</xsl:apply-templates>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
