<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="otmCall">
		<xsl:param name="position-prefix" select="string('')"/>
		<table>
			<xsl:attribute name="class">tableRules <xsl:call-template name="active" /></xsl:attribute>
			<tr>
				<td>
					<xsl:apply-templates select="@description"/>
					<xsl:value-of select="concat($position-prefix,position())"/>: Execute an Onyx logical method
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Object = <xsl:apply-templates select="object"/>
				</td>
			</tr>
			<tr>
				<td class="cellContent">
					Method = <xsl:apply-templates select="method"/>
				</td>
			</tr>
			<xsl:if test="mergeMethodStatus">
				<tr>
					<td class="cellContent">
						Merge method status?
						<xsl:choose>
							<xsl:when test="mergeMethodStatus[.='1']">
								Yes
							</xsl:when>
							<xsl:otherwise>
								No
							</xsl:otherwise>
						</xsl:choose>
					</td>
				</tr>
			</xsl:if>
			<xsl:if test="onError">
				<tr>
					<td class="cellContent">
						On error action = <span class="textLiteral">"<xsl:value-of select="onError"/>"</span>
					</td>
				</tr>
			</xsl:if>
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

	<xsl:template match="inputParameters[parent::node()[name()='otmCall']]">
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

	<xsl:template match="outputParameters[parent::node()[name()='otmCall']]">
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
