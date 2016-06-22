<%@ Page Language="C#" Inherits="easypost.WWW.PostData" %>
<!DOCTYPE html>
<html>
<head runat="server">
 <title>easypost - Post Data</title>
 <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
 <form id="form1" runat="server">
    <div id="outer">
        <h1>easypost<h1>
        <h2>Post Data</h2>
        <p>Post data to an online file.</p>      
        <table>
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
            <td>File name:</td><td><asp:TextBox runat="server" id="FileName" text="<%= FileName %>"/></td>
            </tr>
            <tr>
                <td></td><td><asp:Button runat="server" id="PostButton" OnClick="PostButton_Click" Text="Post" /></td>
            </tr>
        </table>
    </div>
 </form>
</body>
</html>

