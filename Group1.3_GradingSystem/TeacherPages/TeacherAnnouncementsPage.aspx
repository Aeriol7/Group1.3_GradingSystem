<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherAnnouncementsPage.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherAnnouncementsPage" %>

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
    #TeacherHomeLabel {
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
    #TeacherAnnouncementLabel {
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
    }
    #SetGradesIcon {
        position: fixed;
        top: 212px;
        left: 39px;
        right: 1203px;
        height: 43px;
    }
    #SetGradesLabel {
        position: fixed;
        text-align: center;
        color: #B03E3E;
        font-family: Inter;
        font-size: 100px;
        font-style: normal;
        font-weight: 700;
        line-height: normal;
        top: 221px;
        left: 137px;
        width: 91px;
        right: 1057px;
    }
    .teacher-home-image {
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
    #TeacherUser {
        position: fixed;
        color: #47D466;
        top: 96px;
        left: 940px;
    }
    #TeacherWelcomeLabel {
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
    .welcome-announcements {
        position: fixed;
        top: 95px;
        left: 312px;
        width: 964px;
        height: 39px;
    }
    .announcements-list {
        position: fixed;
        height: 385px;
        width: 441px;
        top: 144px;
        left: 314px;
        background: rgba(152, 144, 144, 0.50);
    }
    #TCAnnouncementsList {
        background-color: grey;
    }
    #TCAnnouncementListLabel{
        position: fixed;
        top: 156px;
        left: 418px;
        color: white;
    }
    .announcements-list-item1 {
        position: fixed;
        top: 226px;
        left: 323px;
        width: 420px;
        height: 54px;
    }
    .announcements-list-item2 {
        position: fixed;
        width: 420px;
        height: 54px;
        top: 301px;
        left: 324px;
    }
    .announcements-list-item3 {
        position: fixed;
        width: 420px;
        height: 54px;
        top: 379px;
        left: 324px;
    }
    .announcements-list-item4 {
        position: fixed;
        width: 420px;
        height: 54px;
        top: 456px;
        left: 325px;
    }
    .announcements-event-name {
        position: fixed;
        top: 375px;
        left: 772px;
        width: 503px;
        height: 147px;
    }
    #EventLabel {
        position: fixed;
        top: 385px;
        left: 786px;
        height: 35px;
        width: 181px;
    }
    #Button1{
        position: fixed;
        top: 39px;
        left: 1204px;
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
    <asp:HyperLink ID="TeacherHomeHL" runat="server" NavigateUrl="TeacherHomePage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="HomeIcon" img src="../imgs/icon_home.png" runat="server" Height="40px" />
        </asp:HyperLink>  
    <asp:HyperLink ID="TeacherHomeLabel" runat="server" NavigateUrl="TeacherHomePage.aspx" Text="Home" Font-Size="14pt" Font-Underline="False"></asp:HyperLink>
    <asp:HyperLink ID="TeacherAnnouncementHL" runat="server" NavigateUrl="TeacherAnnouncementsPage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="AnnouncementIcon" img src="../imgs/mdi_announcement.png" runat="server" />
        </asp:HyperLink>   
    <asp:HyperLink ID="TeacherAnnouncementLabel" runat="server" NavigateUrl="TeacherAnnouncementsPage.aspx" Text="Announcements" Font-Size="14pt" Font-Underline="False"></asp:HyperLink>
    <asp:HyperLink ID="SetGradesHL" runat="server" NavigateUrl="TeacherSetGradesPage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="SetGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
        </asp:HyperLink>  
    <asp:HyperLink ID="SetGradesLabel" runat="server" NavigateUrl="TeacherSetGradesPage.aspx" Font-Size="14pt" Text="Set Grades" Font-Underline="False"></asp:HyperLink>
    <div class="welcome-announcements">
        <asp:Panel ID="TCWelcomeAPanel" runat="server" Height="36px" BorderStyle="Outset">
        <asp:Label ID="TCWelcomeALabel" runat="server" Text="Welcome to Announcements, " Font-Names="Arial" Font-Size="20pt"></asp:Label>
        <asp:Label ID="TeacherUser" runat="server" Text="Teacher" Font-Names="Arial" Font-Size="20pt"></asp:Label>
        </asp:Panel>
    </div>
    <div class="announcements-list">
            
        <asp:Panel ID="TCAnnouncementsList" runat="server" Height="381px" BackColor="Silver" BorderStyle="Outset">
            <asp:Label ID="TCAnnouncementListLabel" runat="server" Text="Announcement List" Font-Names="Arial" Font-Size="20pt"></asp:Label>
            <div class="announcements-list-item1">
                    <asp:Panel ID="TCAnnouncement1" runat="server" Height="60px" Width="420px" BackColor="#FFA7A7">
                    </asp:Panel>
            </div>
            <div class="announcements-list-item2">
                    <asp:Panel ID="TCAnnouncement2" runat="server" Height="60px" Width="417px" BackColor="White">
                    </asp:Panel>
            </div>  
            <div class="announcements-list-item3">
                    <asp:Panel ID="TCAnnouncement3" runat="server" Height="60px" Width="418px" BackColor="White">
                    </asp:Panel>
            </div>  
            <div class="announcements-list-item4">
                    <asp:Panel ID="TCAnnouncement4" runat="server" Height="60px" Width="418px" BackColor="White">
                    </asp:Panel>
            </div>  
        </asp:Panel>          
    </div>
    <div class="announcements-event-name">
        <asp:Panel ID="EventPanel" runat="server" Height="148px" BorderStyle="Outset">
            <asp:Label ID="EventLabel" runat="server" Font-Names="Arial" Font-Size="XX-Large" ForeColor="Red">Event Name</asp:Label>
        </asp:Panel>
    </div>
     </form>
</body>
<%--<asp:Image ID="SetCriteriaIcon" img src="../imgs/icon-park_mail-review.png" runat="server" Height="40px" />
<asp:Label ID="SetCriteriaLabel" runat="server" Text="Set Criteria" Font-Size="14pt"></asp:Label>--%>