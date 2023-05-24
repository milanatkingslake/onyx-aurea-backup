<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="webServiceCall">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: Call a web service method
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					WSDL URL = <xsl:apply-templates select="wsdl"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Service = <xsl:apply-templates select="service"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Method = <xsl:apply-templates select="method"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					<xsl:apply-templates select="inputParameters">
						<xsl:with-param name="position-prefix" select="concat($position-prefix,position(),'.')"/>
					</xsl:apply-templates>
					<xsl:apply-templates select="outputParameters">
						<xsl:with-param name="position-prefix" select="concat($position-prefix,position(),'.')"/>
					</xsl:apply-templates>
				</td>
			</tr>
		</table>
	</xsl:template>

	<xsl:template match="inputParameters[parent::node()[name()='webServiceCall']]">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">
				tableRules <xsl:call-template name="active" />
			</xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					Input Parameters:
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

	<xsl:template match="outputParameters[parent::node()[name()='webServiceCall']]">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">
				tableRules <xsl:call-template name="active" />
			</xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					Output Parameters:
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
