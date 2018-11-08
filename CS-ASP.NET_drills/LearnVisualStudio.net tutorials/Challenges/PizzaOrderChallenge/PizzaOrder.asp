<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaOrder.aspx.cs" Inherits="ChallengeFour.PizzaOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: xx-large;
        }
        .auto-style2 {
            color: #FFFFFF;
            background-color: #000000;
        }
        .auto-style3 {
            font-size: x-small;
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style6 {
            color: #FF6600;
            font-family: Georgia, "Times New Roman", Times, serif;
        }
        .auto-style7 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style8 {
            font-size: large;
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .auto-style9 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: xx-large;
        }
        .auto-style10 {
            margin-top: 0px;
        }
        .auto-style11 {
            font-size: small;
        }
        .auto-style12 {
            height: 126px;
        }
        .auto-style13 {
            color: #33CC33;
            text-decoration: underline;
        }
        .auto-style15 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p>
            <asp:Image ID="catPizza" runat="server" CssClass="auto-style10" Height="122px" ImageAlign="TextTop" ImageUrl="~/App_Data/superthumb.jpg" Width="149px" />
&nbsp;<span class="auto-style1">&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span> <strong><span class="auto-style15">Fat</span></strong><span class="auto-style1"><span class="auto-style2">Cat</span></span><span class="auto-style9"> Pies</span></p>
        <p>
            <asp:RadioButtonList ID="sizeRadio" runat="server" CssClass="auto-style3" OnSelectedIndexChanged="sizeRadio_SelectedIndexChanged">
                <asp:ListItem Value="Small">Small (10&#39;&#39;) = $10</asp:ListItem>
                <asp:ListItem Value="Medium">Medium(13&#39;&#39;) = $13</asp:ListItem>
                <asp:ListItem Value="Large">Large(16&#39;&#39;) = $16</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            ______________________________________________________</p>
        <p>
            <asp:RadioButtonList ID="crustRadio" runat="server" CssClass="auto-style3" OnSelectedIndexChanged="crustRadio_SelectedIndexChanged">
                <asp:ListItem Value="Thin">Thin Crust</asp:ListItem>
                <asp:ListItem Value="Deep">Deep Dish (+$2)</asp:ListItem>
                <asp:ListItem Value="Stuff">Stuffed (+$3)</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            _____________________________________________________________________</p>
        <p class="auto-style12">
            <asp:CheckBox ID="pepCheck" runat="server" CssClass="auto-style11" OnCheckedChanged="CheckBox1_CheckedChanged1" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="onionCheck" runat="server" CssClass="auto-style11" OnCheckedChanged="CheckBox2_CheckedChanged2" Text="Onions (+$1)" />
            <br />
            <asp:CheckBox ID="greenCheck" runat="server" CssClass="auto-style11" OnCheckedChanged="CheckBox3_CheckedChanged3" Text="Green Peppers (+.50)" />
            <br />
            <asp:CheckBox ID="redCheck" runat="server" CssClass="auto-style11" OnCheckedChanged="CheckBox4_CheckedChanged4" Text="Red Peppers (+$.75)" />
            <br />
            <asp:CheckBox ID="ancCheck" runat="server" CssClass="auto-style11" OnCheckedChanged="CheckBox5_CheckedChanged5" Text="Anchovies (+$2)" />
            <br />
            <asp:CheckBox ID="sausageCheck" runat="server" CssClass="auto-style11" OnCheckedChanged="CheckBox6_CheckedChanged6" Text="Sausage (+$2)" />
        </p>
        <p>
            ________________________________________________________________________________________</p>
        <p class="auto-style5">
            KITTYFAT<span class="auto-style6"><strong>SPECIAL</strong></span></p>
        <p class="auto-style7">
            Save <strong><span class="auto-style13">$2.00</span> </strong>when you buy a side of <em><strong>Anchovies</strong></em> for your cat (OR) a side of <em><strong>Sausage</strong></em> for your dog.</p>
        <p class="auto-style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="bonusAnch" runat="server" Text="side Anchovies" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="bonusSaus" runat="server" Text="side Sausage" />
        </p>
        <p class="auto-style7">
            __________________________________________________________________________________________________________________</p>
        <p class="auto-style7">
            &nbsp;
            <asp:Button ID="orderButton" runat="server" Text="ORDER" />
        </p>
        <p class="auto-style7">
            <strong><span class="auto-style8">Total: </span></strong>
            <asp:Label ID="priceLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
