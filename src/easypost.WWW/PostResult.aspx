<%@ Page Language="C#" Inherits="easypost.WWW.PostResult" %>
<!DOCTYPE html>
<html>
<head runat="server">
 <title>easypost - Post Complete</title>
 <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
 <form id="form1" runat="server">
    <div id="outer">
        <h1>easypost<h1>
        <h2>Post Complete</h2>
        <p>Your data has been posted. It is now available to view online.</p>
        <h2>Post Details</h2>
        <table>
            <tr>
                <td colspan="2">Post Details</td>
            </tr>
            <tr>
                <td nowrap>Action:</td><td><%= Action %></td>
            </tr>
            <tr>
                <td nowrap>Text:</td><td><%= TextData %></td>
            </tr>
            <tr>
                <td nowrap>File Name:</td><td><%= FileName %></td>
            </tr>
            <tr>
                <td nowrap>Folder Id:</td><td><%= FolderId %></td>
            </tr>
            <tr>
                <td nowrap>Folder Title:</td><td><%= FolderTitle %></td>
            </tr>
        </table>
        <h2>View/Access</h2>
        <a href="http://easypost.io/content/<%= FolderId %>/<%= FileName %>">http://easypost.io/content/<%= FolderId %>/<%= FileName %></a>
        <h2>File Content</h2>
        <textarea style="width: 100%;"><%= FileContent %></textarea>
        <h2>Repost</h2>
        <p>You can repost the same data:</p>
        <asp:Button runat="server" id="Repost" text="Repost" />
        <h2>Return</h2>
        <p>Return to the post data form to enter different data:</p>
        <a href="PostData.aspx?file=<%= FileName %>&folder=<%= FolderId %>">return to form</a>
    </div>
 </form>
</body>
</html>

