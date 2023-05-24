<?xml version="1.0" encoding="utf-8"?>
<!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="@description">
		<xsl:if test="self::node()[.!='']">
			<div class="textDescription">
				** <xsl:value-of select="."/> **
			</div>
		</xsl:if>
	</xsl:template>

</xsl:stylesheet>
