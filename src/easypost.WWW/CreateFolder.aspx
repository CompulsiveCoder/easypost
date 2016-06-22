<%@ Page Language="C#" Inherits="easypost.WWW.CreateFolder" %>
<!DOCTYPE html>
<html>
<head runat="server">
 <title>easypost - Create Folder</title>
 <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
 <form id="form1" runat="server">
    <div id="outer">
        <h1>easypost<h1>
        <h2>Create Folder</h2>
        <p>Before you can post data, you need to create a folder to post it into.</p>
        <p>Each folder has a uniquely generated ID to ensure they don't conflict, but you can give it a title to help identify it.</p>
        <table>
            <tr>
                <td nowrap>Email Address:</td><td><asp:TextBox runat="server" id="EmailAddress"/><br/>
                    <span class="note">Your email address will be used to verify you are a real human, and prevent the system being abused by bots and spammers.</span></td>
            </tr>
            <tr>
                <td nowrap>Folder Title:</td><td><asp:TextBox runat="server" id="FolderTitle"/><br/>
                    <span class="note">Enter a short title for the folder, to help you identify it.</span></td>
            </tr>
            <tr>
                <td></td><td><asp:Button runat="server" id="CreateButton" OnClick="CreateButton_Click" Text="Create" /></td>
            </tr>
            <tr style="display:<%= (!IsPostBack ? "none" : "") %>;">
                <td nowrap>Folder ID:</td><td><asp:TextBox runat="server" id="FolderId"/><br/>
                    <span class="note">This unique ID ensures your folder doesn't conflict with any other folders.</span></td>
            </tr>
            <tr style="display:<%= (!IsPostBack ? "none" : "") %>;">
                <td nowrap>Security Key:</td><td><asp:TextBox runat="server" id="SecurityKey"/><br/>
                    <span class="note">Keep the security key safe. It allows you to post data, while others are prevented from posting.</span></td>
            </tr>
            <tr style="display:<%= (!IsPostBack ? "none" : "") %>;">
                <td></td><td><asp:Button runat="server" id="NextButton" OnClick="NextButton_Click" Text="Next" /></td>
            </tr>
        </table>
    </div>
 </form>
</body>
</html>

