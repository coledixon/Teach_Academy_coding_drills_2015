<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConditionalRadio.aspx.cs" Inherits="ChallengeThree.ConditionalRadio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
            font-size: large;
        }
        .auto-style3 {
            font-size: small;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style4 {
            font-size: medium;
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <p>
            <strong>FILM PREFERENCE</strong></p>
        <p aria-dropeffect="copy">
            <asp:RadioButtonList ID="filmList" runat="server" ClientIDMode="AutoID" CssClass="auto-style3" OnSelectedIndexChanged="filmList_SelectedIndexChanged">
                <asp:ListItem>ScienceFiction</asp:ListItem>
                <asp:ListItem>Action</asp:ListItem>
                <asp:ListItem>Horror</asp:ListItem>
                <asp:ListItem>Romance</asp:ListItem>
                <asp:ListItem>Western</asp:ListItem>
                <asp:ListItem>Comedy</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p aria-dropeffect="copy">
            <asp:Button ID="okButton" runat="server" Text="OK" />
        </p>
        <p aria-dropeffect="copy">
            <asp:Image ID="filmImg" runat="server" Height="90px" Width="99px" />
        </p>
        <p aria-dropeffect="copy">
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style4"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
