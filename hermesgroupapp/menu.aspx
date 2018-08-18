<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="hermesgroupapp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id ="menu">
            <ul>
                <li><a href ="hermesgroup">Promo planning</a></li>
                <li><a href ="#">Base planning</a></li>
                <li><a href ="#">Fixed TE</a></li>
                <li><a href ="#">Master Data</a>
                    <ul>
                        <li><a href="#">Customers</a></li>
                        <li><a href="masterdata\country">Countries</a></li>
                        <li><a href="#">Channels</a></li>
                        <li><a href="#">Segment</a></li>
                        <li><a href="#">Brands</a></li>
                        <li><a href="#">Technologies</a></li>
                        <li><a href="#">Products</a></li>
                    </ul>
                </li>
                <li><a href ="#">Masterfile</a></li>
            </ul>
        </div>
    </form>
</body>
</html>
