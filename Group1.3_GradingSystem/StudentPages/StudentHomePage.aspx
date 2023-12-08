<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" Inherits="Group1._3_GradingSystem.StudentPages.StudentHomePage" %>

<!DOCTYPE html>
<style type="text/css">
    #Panel1{
        position: fixed;
    }
    #Image1 {
        position: fixed;
        margin-right: 15px;
        margin-left: 15px;
        top: 14px;
        left: 12px;
        width: 58px;
        height: 58px;
    }
    #LogoutDropDown {
        position: fixed;
        top: 35px;
        left: 1211px;
    }
    #UserIcon {
        position: fixed;
        top: 26px;
        left: 1137px;
        height: 40px;
        width: 40px;
        right: 108px;
    }
    #Label1 {
        position: fixed;
        top: 20px;
        left: 105px;
    }
    #NavPanel {
        position: fixed;

    }
    #HomeIcon {
    position: fixed;
    top: 88px;
    left: 38px;
    width: 44px;
    height: 43px;
    }
    #StudentHomeLabel {
    position: fixed;
    top: 98px;
    left: 160px;
    height: 28px;
    width: 54px;
    text-align: center;
    color: #B03E3E;
    font-family: Inter;
    font-size: 100px;
    font-style: normal;
    font-weight: 700;
    line-height: normal;
    }
    #AnnouncementIcon {
    position: fixed;
    width: 48px;
    top: 149px;
    left: 37px;
    height: 45px;
    }
    #StudentAnnouncementLabel {
    position: fixed;
    text-align: center;
    color: #B03E3E;
    font-family: Inter;
    font-size: 100px;
    font-style: normal;
    font-weight: 700;
    line-height: normal;
    top: 159px;
    left: 122px;
    width: 129px;
    }
    #ViewGradesIcon {
    position: fixed;
    top: 161px;
    left: 45px;
    right: 1189px;
    height: 43px;
    }
    #ViewGradesLabel {
    position: fixed;
    text-align: center;
    color: #B03E3E;
    font-family: Inter;
    font-size: 100px;
    font-style: normal;
    font-weight: 700;
    line-height: normal;
    top: 156px;
    left: 142px;
    width: 91px;
    right: 1044px;
    }
    .Student-home-image {
        position: fixed;
        height: 464px;
        width: 994px;
        top: 86px;
        left: 278px;
    }
    #StudentWelcome{
        position: fixed;
        top: 85px;
        left: 278px;
        height: 534px;
        width: 1007px;
    }
    #StudentUser {
        position: fixed;
        top: 90px;
        left: 460px;
        color: #47D466;
    }
    #StudentWelcomeLabel {
        position: fixed;
        top: 89px;
        left: 274px;
        height: 45px;
        width: 180px;
        color: #D44747;
    }
    #form1 {
        height: 604px;
    }
    .nav-tree-view {
        height: 379px;
        width: 254px;
    }
    #Button1{
        position: fixed;
        top: 36px;
        left: 1209px;
    }
    </style>

<form id="form1" runat="server">

<header style="height: 63px">
        <nav style="height: 66px">
            <asp:Image ID="Image1" img src="../imgs/HopeLogo_TransparentPng.png" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="HOPE INTEGRATED SCHOOL" Font-Bold="False" Font-Size="16pt" Width="204px" Font-Names="Times New Roman"></asp:Label>

            <asp:Image ID="UserIcon" img src="../imgs/ProfileIcon1.png" runat="server" />

            <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />

       </nav>
</header>
<head runat="server">
    <title></title>
</head>
<body style="height: 603px; width:1440px;">
    <asp:HyperLink ID="StudentHomeHL"  runat="server" NavigateUrl="StudentHomePage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="HomeIcon" img src="../imgs/icon_home.png" runat="server" Height="40px" />
        </asp:HyperLink>
    <asp:HyperLink ID="StudentHomeLabel"  runat="server" NavigateUrl="StudentHomePage.aspx" Font-Size="14pt" Font-Underline="False">Home</asp:HyperLink>

    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="ViewGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
        </asp:HyperLink>
    <asp:HyperLink ID="ViewGradesLabel" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">View Grades</asp:HyperLink>
        <asp:Label ID="StudentWelcomeLabel" runat="server" Font-Names="Arial" Font-Size="30pt">Welcome, </asp:Label>
        <asp:Label ID="StudentUser" runat="server" Font-Names="Arial" Font-Size="30pt">Student! </asp:Label>
        <asp:Image ID="StudentWelcome" img src="../imgs/Graphic1.png" runat="server" />
    </form>
</body>
