<%@ Page Language="C#" Inherits="easypost.WWW.CreateKey" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Create Key</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button runat="server" Text="Create Keys" id="CreateKeyButton" OnClick="CreateKeyButton_Clicked" />
		<p>
		Unique ID: <%= Keys.FolderName %><br/>
		Security Key: <%= Keys.SecurityKey %><br/>
		</p>
	</form>
</body>
</html>

