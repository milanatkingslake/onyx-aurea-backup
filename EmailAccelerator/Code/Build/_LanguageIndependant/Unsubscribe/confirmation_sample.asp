<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<!-- Copyright Aptean 2017. All rights reserved. -->
<html>
<head>
	<title>Unsubscribe Confirmation</title>
</head>

<body bgcolor="#FFFFFF" text="#000000">
<div align="center">
<br>
<table border="0" cellspacing="0" cellpadding="0" width="500">
<tr>
	<td colspan="2">
		<table cellspacing="0" cellpadding="0" style="border-width: 1px; border-style: solid; border-color: #999999; border: 1px #999999 solid;">
		<tr>
			<td>
				<table cellspacing="6" cellpadding="0">
				<tr>
					<td><br>
					<font face="Verdana,Geneva,Arial,Helvetica,sans-serif" color="#666666" style="font-size: 16px;">
					<strong>Unsubscribe Confirmation</strong>
					</font>
					<br><br>
<%
				Select Case Request("unsubID")
					Case "120" 'Newsletter
%>
					<font face="Verdana,Geneva,Arial,Helvetica,sans-serif" color="#666666" style="font-size: 11px; line-height: 170%;">
					You have been successfully unsubscribed from the Monthly Newsletter.
					<br><br>
					</font>
<%
					Case "4120" 'Marketing Announcement
%>
					<font face="Verdana,Geneva,Arial,Helvetica,sans-serif" color="#666666" style="font-size: 11px; line-height: 170%;">
					You have been successfully unsubscribed from New Product Announcements.
					<br><br>
					</font>
<%
					Case Else 'Generic Unsubscribe
%>
					<font face="Verdana,Geneva,Arial,Helvetica,sans-serif" color="#666666" style="font-size: 11px; line-height: 170%;">
					You have been successfully unsubscribed.
					<br><br>
					</font>
<%
				End Select
%>
					</td>
				</tr>
				</table>
			</td>
		</tr>
		</table>
	</td>
</tr>
</table>
</div>

</body>
</html>
