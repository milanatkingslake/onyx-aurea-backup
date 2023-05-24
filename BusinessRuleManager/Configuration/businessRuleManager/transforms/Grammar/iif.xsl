<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="iif">
		<table cellspacing="0">
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="@description"/>
					IIF (return a conditional expression)
				</td>
			</tr>
			<tr>
				<td class="cellContent2">
					<xsl:apply-templates select="test" />
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="then"/>
					<xsl:apply-templates select="else"/>
				</td>
			</tr>
		</table>
	</xsl:template>

	<xsl:template match="test[parent::node()[name()='iif']]">
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

	<xsl:template match="then[parent::node()[name()='iif']]">
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					THEN expression
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="*"/>
				</td>
			</tr>
		</table>
	</xsl:template>

	<xsl:template match="else[parent::node()[name()='iif']]">
		<table>
			<xsl:attribute name="class">
				tableRules <xsl:call-template name="active" />
			</xsl:attribute>
			<tr>
				<td>
					ELSE expression
					<xsl:apply-templates select="@description"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="*"/>
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
