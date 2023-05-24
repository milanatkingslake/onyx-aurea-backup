<?xml version="1.0" encoding="utf-8"?> <!-- Copyright Aptean 2017. All rights reserved. -->
<!-- Copyright Aptean 2017. All rights reserved. -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:output method="xml" omit-xml-declaration="yes"/>
	
	<xsl:template match="stringTests">
		<description>
			<xsl:value-of select="description"/>
		</description>
	</xsl:template>

</xsl:stylesheet>
