<%@ Page Language="C#" Inherits="easypost.WWW.Folder" %>
<!DOCTYPE html>
<html>
<head runat="server">
 <title>easypost - Folder: <%= FolderTitle %></title>
 <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
 <form id="form1" runat="server">
    <div id="outer">
        <h1>easypost</h1>
        <h2>Folder: <%= FolderTitle %></h2>
        <table>
            <tr><td colspan="2">Files</td>
            <tr>
                <td><a href="content/<%= FolderId %>/Hello.txt">Hello.txt</a> - [<a href="PostData.aspx?FolderId=<%= FolderId %>&file=Hello.txt">Post</a>]</td>
            </tr>
        </table>
    </div>
 </form>
</body>
</html>

