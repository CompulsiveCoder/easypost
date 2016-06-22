<%@ Page Language="C#" Inherits="easypost.WWW.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
 <title>easypost - Welcome!</title>
 <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
 <form id="form1" runat="server">
   <div id="outer">
    <h1>Welcome easypost</h1>
    <p>easypost makes it easy to publish simple data and static content (such as html and javascript) to the web.</p>
    <ul>
        <li><a href="Start.aspx">Getting started...</a></li>
    </ul>
    <h2>What is it for?</h2>
    <p>easypost is ideal for publishing chunks of information such as:</p>
    <ul>
        <li>Sensor data</li>
        <li>Build logs</li>
        <li>Test reports</li>
        <li>Application error logs</li>
        <li>Version information</li>
        <li>Simple static HTML/javascript/CSS sites</li>
    </ul>
    <h2>What is it NOT for?</h2>
    <p>easypost is intended for public information. Some applications are not suited to using easpost such as publishing:</p>
    <ul>
        <li>Personal user information</li>
        <li>Passwords</li>
        <li>Private financial data</li>
    </ul>
    <h2>How can I post data?</h2>
    <p>easypost allows data to be published to the web using the following methods:</p>
    <ul>
        <li>HTTP GET requests</li>
        <li>HTTP POST requests (pending)</li>
        <li>Programming API
            <ul>
            <li>C#</li>
            </ul>
        </li>
        <li>Terminal / command line interface (CLI)</li>
    </ul>
    <h2>easypost is open source</h2>
    <p>The software behind the easypost service is open source so anyone can launch their own server. Get the code here:</p>
    <ul>
        <li><a href="">GitHub source repository</a></li>
    </ul>
   </div>
 </form>
</body>
</html>

