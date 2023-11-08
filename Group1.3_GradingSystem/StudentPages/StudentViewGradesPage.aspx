<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewGradesPage.aspx.cs" Inherits="Group1._3_GradingSystem.StudentPages.StudentViewGradesPage" %>

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
    top: 212px;
    left: 39px;
    right: 1203px;
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
    top: 208px;
    left: 141px;
    width: 91px;
    right: 1053px;
    }
    .Student-home-image {
        position: fixed;
        height: 464px;
        width: 994px;
        top: 86px;
        left: 278px;
    }
    #TCWelcomeALabel{
        position: fixed;
        top: 96px;
        left: 580px;
        color: #B03E3E;
    }
    #StudentUser {
        position: fixed;
        color: #47D466;
        top: 96px;
        left: 940px;
    }
    #StudentWelcomeLabel {
        position: fixed;
        top: 89px;
        left: 274px;
        height: 45px;
        width: 180px;
        color: #D44747;
        right: 831px;
    }
    #form1 {
        height: 523px;
    }
    .nav-tree-view {
        height: 379px;
        width: 254px;
    }
    .set-grades-container {
        position: fixed;
        top: 93px;
        left: 317px;
        width: 960px;
        height: 436px;
    }
    #SViewGradesLabel {
        position: fixed;
        top: 111px;
        left: 338px;
        height: 40px;
        width: 197px;
    }
    #VGPrintRecord {
        position: fixed;
        top: 169px;
        left: 344px;
        width: 94px;
        right: 847px;
    }
    #VGButton1 {
        position: fixed;
        top: 170px;
        left: 465px;
        width: 91px;
    }
    #VGButton2 {
        position: fixed;
        top: 170px;
        left: 582px;
        width: 91px;
    }
    #VGSearchLabel {
        position: fixed;
        top: 210px;
        left: 1018px;
        bottom: 335px;
    }
    #VGSearchTxt {
        position: fixed;
        top: 209px;
        left: 1087px;
        width: 176px;
    }
    #VGNext {
        position: fixed;
        top: 492px;
        left: 1225px;
    }
    #VGPrev {
        position: fixed;
        top: 490px;
        left: 1095px;
    }
    .view-grades-table {
        position: fixed;
        top: 217px;
        left: 327px;
        height: 301px;
        width: 938px;
    }
    #Button1{
        position: fixed;
        top: 39px;
        left: 1207px;
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
    <asp:HyperLink ID="StudentAnnouncementshL" NavigateUrl="StudentAnnouncementsPage.aspx" runat="server" Font-Size="14pt" Font-Underline="False">    
        <asp:Image ID="AnnouncementIcon" img src="../imgs/mdi_announcement.png" runat="server" />
        </asp:HyperLink>
    <asp:HyperLink ID="StudentAnnouncementLabel" NavigateUrl="StudentAnnouncementsPage.aspx" runat="server" Font-Size="14pt" Font-Underline="False">Announcements</asp:HyperLink>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="ViewGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
        </asp:HyperLink>
    <asp:HyperLink ID="ViewGradesLabel" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">View Grades</asp:HyperLink>
    <div class="set-grades-container">
        <asp:Label ID="SViewGradesLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="20pt" ForeColor="#983939">View Grades</asp:Label>
        <asp:Button ID="VGPrintRecord" runat="server" Text="Print Grades" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        <div class="view-grades-table"></div>
    </div>
     </form>
</body>
