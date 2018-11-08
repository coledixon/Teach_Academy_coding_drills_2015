<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EpicSpies.aspx.cs" Inherits="ChallengeSix.EpicSpies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            font-size: x-large;
        }
        .auto-style2 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style4 {
            font-family: Fixedsys;
            font-size: medium;
        }
        .auto-style5 {
            text-decoration: underline;
        }
        .auto-style6 {
            width: 503px;
        }
        .auto-style7 {
            width: 662px;
            margin-left: 3px;
        }
        .auto-style8 {
            width: 656px;
            margin-left: 19px;
        }
        .auto-style9 {
            font-family: Fixedsys;
            font-size: medium;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Data/gI_73166_spy-dialer-icon-512x512.jpg" Width="127px" />
&nbsp;
            <br />
            <span class="auto-style1"><strong>SPY</strong>talfields, London</span></p>
        <p class="auto-style2">
            [SPY ASSIGNMENT FORM]</p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style4">
            <span class="auto-style5">Code Name</span>
            <asp:TextBox ID="codeBox" runat="server" Width="142px"></asp:TextBox>
        </p>
        <p class="auto-style4">
            <span class="auto-style5">Assignment</span>
            <asp:TextBox ID="assignBox" runat="server" Width="183px"></asp:TextBox>
        </p>
        <p class="auto-style4">
            &nbsp;</p>
        <hr class="auto-style7" />
        <p class="auto-style4">
            &nbsp;</p>
        <p class="auto-style4">
            PREVIOUS ASSIGNMENT TERMINATION</p>
        <p class="auto-style9">
            <asp:Calendar ID="prevCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="prevCalendar_SelectionChanged" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
        </p>
        <hr class="auto-style6" />
        <p class="auto-style4">
            NEW ASSIGNMENT AUTHORIZATION</p>
        <p class="auto-style4">
            <asp:Calendar ID="startCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="startCalendar_SelectionChanged" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
        </p>
        <hr class="auto-style8" />
        <p class="auto-style4">
            PROJECTED ASSIGNMENT TERMINATION</p>
        <p class="auto-style4">
            <asp:Calendar ID="endCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="endCalendar_SelectionChanged" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
        </p>
        <p class="auto-style4">
            <asp:Button ID="missionButton" runat="server" OnClick="missionButton_Click" Text="ASSIGN MISSION" />
        </p>
        <p class="auto-style4">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
