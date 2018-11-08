<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleCalculator.aspx.cs" Inherits="ChallengeTwo.SimpleCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: x-large;
        }
    </style>
</head>
<body style="width: 446px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>SIMPLE CALCULATOR</strong></div>
        <p>
            ENTER A VALUE:&nbsp;&nbsp;
            <asp:TextBox ID="valueInput" runat="server"></asp:TextBox>
        </p>
        <p>
            ENTER ANOTHER VALUE:&nbsp;&nbsp;
            <asp:TextBox ID="valueInput2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ADD" runat="server" OnClick="ADD_Click" Text="+" Width="29px" />
&nbsp;
            <asp:Button ID="SUB" runat="server" OnClick="SUB_Click" Text="-" Width="28px" />
&nbsp;
            <asp:Button ID="MULTI" runat="server" OnClick="MULTI_Click" Text="*" Width="28px" />
&nbsp;
            <asp:Button ID="DIV" runat="server" OnClick="DIV_Click" Text="/" Width="28px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CLEAR" runat="server" OnClick="CLEAR_Click" Text="CLEAR" />
        </p>
        <p id="resultLabel">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
