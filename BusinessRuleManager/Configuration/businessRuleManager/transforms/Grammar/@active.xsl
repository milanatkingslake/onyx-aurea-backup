<?xml version="1.0" encoding="utf-8"?>
<!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template name="active">
		<xsl:if test="ancestor-or-self::node()[@active='0']">tableRulesInactive</xsl:if>
	</xsl:template>

</xsl:stylesheet>
