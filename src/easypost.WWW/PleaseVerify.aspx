<%@ Page Language="C#" Inherits="easypost.WWW.PleaseVerify" %>
<!DOCTYPE html>
<html>
<head runat="server">
 <title>easypost - Email Address Verification</title>
 <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
 <form id="form1" runat="server">
    <div id="outer">
        <h1>easypost<h1>
        <h2>Email Address Verification</h2>
        <p>Please check your email inbox, and open the verification link.</p>
        <p><asp:Button runat="server" id="ResendButton" Text="Resend Email" /></p>
    </div>      
 </form>
</body>
</html>

