<%@ Page Language="C#" Inherits="easypost.WWW.HttpGet" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>easy post - Posted!</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
	<form id="form1" runat="server">
		<h1>easy post</h1>
		<% if (DidPublish){ %>
		<div>The provided text has been published.</div>
        <h2>Details</h2>
		<div>Text: <%= TextData %></div>
		<div>File name: <%= FileName %></div>
        <div>Unique ID: <%= FolderName %></div>
        <div>Security key: <%= SecurityKey %></div>
        <div>Action: <%= Action %></div>
		<div>&nbsp;</div>
        <h2>View/Access Data</h2>
		<div>You can access the data via the following links:</div>
		<div><a href='<%= FileUrl %>'><%= FileUrl %></a></div>      
		<div>&nbsp;</div>
        <h2></h2>
		<div>Post data using the following link:</div>
		<div><a href='<%= PostUrl %>'><%= PostUrl %></a></div>
		<div>Try it out by opening the link above in the browser. Every time the page loads it should add that text to the specified filed.</div>
		<div><input type="button" value="&laquo; Back" onclick="location.href='Default.aspx'"/> <input type="button" value="Re-Post" onclick="location.reload();"/></div>
		<% } else { %>
		<div>Invalid arguments. Publish aborted.</div>
		<% } %>
	</form>
</body>
</html>

