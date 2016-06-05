<%@ Page Language="C#" Inherits="easypost.WWW.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>easy post</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
	<form id="form1" runat="server">
        <div id="outer">
		<h1>easy post</h1>
		<p>Post data to the web using a simple get request.</p>      
		<table style="border-collapse:collapse;">
		    <tr>
        		<td>
        		</td>
        		<td>
        		</td>
            </tr>
            <tr><td colspan="2"><b>Security</b></td></tr>
            <tr><td colspan="2">Enter your security key and device ID.</td></tr>
            <tr><td colspan="2">If you don't have a security key: <asp:Button runat="server" id="CreateKeyButton" OnClick="CreateKeyButton_Click" Text="Create a Key" /></td></tr>
            <tr>
            <td>Unique ID:</td><td><asp:TextBox runat="server" id="FolderName"/></td>
            </tr>
            <tr>
    		<td>Security key:</td><td><asp:TextBox runat="server" id="SecurityKey"/></td>
    		</tr>
            <tr><td colspan="2"><b>Data</b></td></tr>
            <tr><td colspan="2">Enter the file text you want to post, and the file name you want to post it to.</td></tr>
            <tr><td>Option:</td><td>
                <asp:RadioButtonList id="CommandOption" runat="server">
                <asp:ListItem Value="Append" Selected>Append</asp:ListItem>
                <asp:ListItem Value="Overwrite">Overwrite (if exists)</asp:ListItem>
             </asp:RadioButtonList>
            </td></tr>
    		<tr>
    		<td>Text:</td><td><asp:TextBox runat="server" id="TextData" TextMode="MultiLine" Rows="2" width="400" Text="Hello world!" /></td>
    		</tr>      
    		<tr>
    		<td>File name:</td><td><asp:TextBox runat="server" id="File" text="file.txt"/></td>
    		</tr>
		</table>
		<div style="text-align: right"><asp:Button runat="server" id="GoButton" OnClick="GoButton_Click" Text="Post My Data" /></div>
        </div>
	</form>
</body>
</html>

