<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpyTracker.aspx.cs" Inherits="ChallengeSeven.SpyTracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            font-family: System;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>ASSET PERFORMANCE TRACKER</strong><br />
        <br />
        asset name:
        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        <br />
        <br />
        elections rigged:
        <asp:TextBox ID="electBox" runat="server"></asp:TextBox>
        <br />
        <br />
        assassinations performed:
        <asp:TextBox ID="killBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="ADD ASSET" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
    
    </div>
    </form>
</body>
</html>

