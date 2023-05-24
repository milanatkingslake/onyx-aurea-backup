<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="rules">
		<xsl:param name="position-prefix" select="string('')"/>
		<xsl:choose>
			<xsl:when test="parent::node()[.=current()]">
				<html>
					<head>
						<style>
							BODY
							{
							font-family: Verdana;
							}
							.tableRules
							{
							font-size: x-small;
							}
							.tableRulesInactive
							{
							font-style: italic;
							}
							.cellContent
							{
							padding-left: 20px;
							}
							.cellContent2
							{
							padding-left: 40px;
							}
							.textDescription
							{
							color: Green;
							}
							.textLiteral
							{
							color: Blue;
							}
						</style>
					</head>
					<body>
						<xsl:call-template name="Ruleset"/>
					</body>
				</html>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template name="Ruleset">
					<xsl:with-param name="position-prefix" select="$position-prefix"/>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<xsl:template name="Ruleset">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					BEGIN Rule Set
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="*">
						<xsl:with-param name="position-prefix" select="$position-prefix"/>
					</xsl:apply-templates>
				</td>
			</tr>
			<tr>
				<td>
					END Rule Set
				</td>
			</tr>
		</table>
	</xsl:template>

</xsl:stylesheet>
