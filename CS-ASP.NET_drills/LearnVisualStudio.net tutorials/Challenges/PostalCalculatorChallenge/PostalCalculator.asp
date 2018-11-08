<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostalCalculatorChallenge.aspx.cs" Inherits="ChallengeNine.PostalCalculatorChallenge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
            font-size: large;
        }
        .auto-style2 {
            font-family: System;
        }
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            font-family: System;
            font-size: x-large;
        }
        .auto-style5 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        POSTAL CALCULATOR<br />
        <br />
        <span class="auto-style2"><span class="auto-style3">width:</span>&nbsp; </span>
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged" Width="30px"></asp:TextBox>
        <br />
        <span class="auto-style4">height: </span>
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged" Width="34px"></asp:TextBox>
        <br />
        <span class="auto-style4">length: </span>
        <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" OnTextChanged="TextBox3_TextChanged" Width="35px"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadio" runat="server" AutoPostBack="True" CssClass="auto-style5" GroupName="shipment" OnCheckedChanged="groundRadio_CheckedChanged" Text="GROUND" />
        <br />
        <asp:RadioButton ID="airRadio" runat="server" AutoPostBack="True" CssClass="auto-style5" GroupName="shipment" OnCheckedChanged="airRadio_CheckedChanged" Text="AIR" />
        <br />
        <asp:RadioButton ID="nextRadio" runat="server" AutoPostBack="True" CssClass="auto-style5" GroupName="shipment" OnCheckedChanged="nextRadio_CheckedChanged" Text="NEXT DAY" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
