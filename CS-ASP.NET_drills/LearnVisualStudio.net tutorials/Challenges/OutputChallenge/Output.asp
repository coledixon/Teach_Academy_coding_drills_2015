<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge.aspx.cs" Inherits="ChallengeOne.Challenge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your age?&nbsp;
        <asp:TextBox ID="agebox" runat="server" OnTextChanged="age_box_TextChanged"></asp:TextBox>
        <br />
        <br />
        How much money is in your pocket?&nbsp;
        <asp:TextBox ID="moneybox" runat="server" OnTextChanged="money_box_TextChanged"></asp:TextBox>
        <br />
        <br />
        CLICK THE BUTTON
        <br />
        <br />
        <asp:Button ID="submitbutton" runat="server" OnClick="submitbutton_Click" Text="CLICK" />
        <br />
        <br />
        <asp:Label ID="result" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
