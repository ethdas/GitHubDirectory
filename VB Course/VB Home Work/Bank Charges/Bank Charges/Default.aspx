<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Bank_Charges._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            color: #CC3300;
        }
        .auto-style3 {
            width: 100%;
            border: 1px solid #FF0000;
            background-color: #FFFFFF;
        }
        .auto-style4 {
            width: 395px;
        }
        .auto-style5 {
            width: 489px;
        }
        .auto-style6 {
            color: #FFFFFF;
            background-color: #0066FF;
        }
        .auto-style8 {
            color: #000000;
        }
 p.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:0in;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	}
        .auto-style9 {
            width: 395px;
            height: 85px;
            background-color: #FFFFFF;
        }
        .auto-style10 {
            width: 489px;
            height: 85px;
        }
        .auto-style11 {
            height: 85px;
        }
        .auto-style12 {
            color: #FFFFFF;
            background-color: #0000FF;
        }
        .auto-style13 {
            margin-bottom: 0px;
        }
        .auto-style14 {
            background-color: #0066FF;
        }
        .newStyle1 {
            position: relative;
        }
        .auto-style15 {
            width: 489px;
            font-size: xx-small;
        }
        .auto-style16 {
            margin-left: 0px;
        }
        .auto-style24 {
            width: 30px;
            background-color: #FFFFFF;
        }
        .auto-style25 {
            width: 30px;
            height: 85px;
            background-color: #FFFFFF;
        }
        .auto-style26 {
            background-color: #0000FF;
        }
        .auto-style28 {
            width: 204px;
            height: 55px;
            background-color: #FFFFFF;
        }
        .auto-style29 {
            width: 30px;
            height: 55px;
            background-color: #FFFFFF;
        }
        .auto-style30 {
            width: 489px;
            height: 55px;
        }
        .auto-style32 {
            font-size: small;
        }
        .auto-style35 {
            width: 21px;
        }
        .auto-style36 {
            width: 21px;
            height: 55px;
            background-color: #FFFFFF;
        }
        .auto-style37 {
            width: 395px;
            font-size: larger;
            color: #FF0000;
            background-color: #FFFFFF;
        }
        .auto-style39 {
            width: 70px;
            height: 55px;
            background-color: #FFFFFF;
        }
        .auto-style40 {
            width: 3px;
            height: 85px;
            background-color: #FFFFFF;
        }
        .auto-style41 {
            width: 3px;
            background-color: #FFFFFF;
        }
        .auto-style42 {
            width: 3px;
            height: 55px;
            background-color: #FFFFFF;
        }
        .auto-style43 {
            width: 70px;
        }
        .auto-style44 {
            width: 204px;
        }
        .auto-style45 {
            font-size: larger;
            color: #FF3300;
        }
        .auto-style46 {
            width: 395px;
            height: 26px;
        }
        .auto-style47 {
            width: 3px;
            height: 26px;
            background-color: #FFFFFF;
        }
        .auto-style48 {
            width: 489px;
            height: 26px;
        }
        .auto-style49 {
            width: 30px;
            height: 26px;
            background-color: #FFFFFF;
        }
        .auto-style50 {
            height: 26px;
        }
        .auto-style51 {
            font-size: small;
            width: 70px;
        }
        .auto-style56 {
            font-size: small;
            width: 164px;
        }
        .auto-style57 {
            height: 55px;
            width: 164px;
            background-color: #FFFFFF;
        }
        .auto-style58 {
            font-size: small;
            width: 69px;
        }
        .auto-style59 {
            height: 55px;
            width: 69px;
            background-color: #FFFFFF;
        }
        .auto-style60 {
            color: #0000FF;
        }
        .auto-style61 {
            color: #0000FF;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 class="auto-style6">Monthly <span class="auto-style14">Bank</span> Charges Calculator</h1>
            <table align="center" class="auto-style3">
                <tr>
                    <td class="auto-style12" colspan="9">
                        <p class="MsoNormal" style="font-size: medium">
                            <span style="font-family:&quot;Calibri&quot;,sans-serif;
mso-ascii-theme-font:minor-latin;mso-hansi-theme-font:minor-latin;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-bidi-theme-font:minor-bidi" class="auto-style26">To know your total Bank charge for this month, Please Enter the number of checks you have written during this month</span><o:p></o:p></p>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" colspan="3">&nbsp;</td>
                    <td class="auto-style40"></td>
                    <td class="auto-style10">
                        <asp:Image ID="Image1" runat="server" AlternateText="Bank of America" CssClass="auto-style13" Height="84px" ImageUrl="~/logo.jpg" Width="176px" />
                    </td>
                    <td class="auto-style25"></td>
                    <td class="auto-style11" colspan="3"></td>
                </tr>
                <tr>
                    <td class="auto-style37" colspan="3">Introducing My Rewards — all your rewards in one&nbsp;place</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">
                        <p class="MsoNormal">
                            <strong><span style="font-size:12.0pt;line-height:107%;
color:black">How many checks have you written this month? </span></strong><span class="auto-style2"><span style="font-size:12.0pt;line-height:107%;font-family:
&quot;Times New Roman&quot;,serif">&nbsp;&nbsp;&nbsp;<o:p></o:p></span></span></p>
                        <span class="auto-style8"><strong>&nbsp;</strong></span><span class="auto-style2">&nbsp;&nbsp;&nbsp; </span>
                        <asp:TextBox ID="txtChecksWritten" runat="server" BackColor="#99CCFF" CssClass="auto-style2" BorderColor="#FF3300" Font-Size="Medium"></asp:TextBox>
                    </td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style45" colspan="3">Introducing My Rewards — all your rewards in one&nbsp;place</td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <h3 class="cnx-light" style="box-sizing: inherit; margin: 0.2rem 0px 20px; padding: 0px 55px 0px 0px; color: rgb(107, 94, 81); font-family: cnx-light, Arial, Helvetica, sans-serif; font-style: normal; font-weight: 200; line-height: 1.458; text-rendering: optimizeLegibility; font-size: 24px; visibility: visible; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">&nbsp;</h3>
                    </td>
                    <td class="auto-style44"><span class="auto-style32">Track your rewards, deals and benefits throughout the year and see what you might be missing out&nbsp;on</span>.</td>
                    <td class="auto-style43">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style51">&nbsp;</td>
                    <td class="auto-style56">Is a new home in your future? Let us help you get there with the right mortgage. </td>
                    <td class="auto-style58">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style28">
                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style60" ForeColor="Blue" NavigateUrl="https://www.bankofamerica.com/preferred-rewards/my-rewards/" Target="_blank">Learn more</asp:HyperLink>
                    </td>
                    <td class="auto-style39">&nbsp;</td>
                    <td class="auto-style42"></td>
                    <td class="auto-style30">
                        <asp:Button ID="btnCalc" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Size="Small" ForeColor="#0033CC" Text="Calculate your Monthly Total Charge" />
                        <br />
                    </td>
                    <td class="auto-style29"></td>
                    <td class="auto-style39">&nbsp;</td>
                    <td class="auto-style57">
                        <asp:HyperLink ID="HyperLink3" runat="server" CssClass="auto-style61" ForeColor="Blue" NavigateUrl="https://www.bankofamerica.com/mortgage/home-mortgage/" Target="_blank">Learn more</asp:HyperLink>
                    </td>
                    <td class="auto-style59">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnClear" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Size="Small" ForeColor="#0033CC" Text="Clear" CssClass="auto-style16" Width="86px" />
                    </td>
                    <td class="auto-style24">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblMonthlyBankFee" runat="server" Text="Your  Bank Charge for this month  would be Shown Here" ForeColor="#0033CC"></asp:Label>
                    </td>
                    <td class="auto-style24">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style46" colspan="3"></td>
                    <td class="auto-style47"></td>
                    <td class="auto-style48">
                        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#FF3300" NavigateUrl="https://www.bankofamerica.com/" Target="_blank">Click Here to Return to Our Main Page</asp:HyperLink>
                    </td>
                    <td class="auto-style49"></td>
                    <td class="auto-style50" colspan="3"></td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style15">&nbsp;2018 Bank of America Corporation</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
