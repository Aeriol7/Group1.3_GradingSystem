﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherSetGradesPage.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherSetGradesPage" %>

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
    .set-grades-container {
        position: fixed;
        top: 93px;
        left: 317px;
        width: 960px;
        height: 436px;
    }
    #TSetGradesLabel {
        position: fixed;
        top: 111px;
        left: 338px;
        height: 40px;
        width: 197px;
    }
    #SGAddRecord {
        position: fixed;
        top: 446px;
        left: 825px;
        width: 94px;
    }
    #SGButton1 {
        position: fixed;
        top: 445px;
        left: 956px;
        width: 91px;
    }
    #SGButton2 {
        position: fixed;
        top: 446px;
        left: 1077px;
        width: 91px;
    }
    #SGSearchLabel {
        position: fixed;
        top: 260px;
        left: 1104px;
        bottom: 285px;
    }
    #SGSearchTxt {
        position: fixed;
        top: 209px;
        left: 1087px;
        width: 176px;
    }
    #SGNext {
        position: fixed;
        top: 492px;
        left: 1225px;
    }
    #SGPrev {
        position: fixed;
        top: 490px;
        left: 1095px;
    }
    .set-grades-table {
        position: fixed;
        top: 242px;
        left: 332px;
        width: 471px;
        height: 239px;
    }
    .set-grades-form {
        position: fixed;
        top: 245px;
        left: 814px;
        height: 239px;
        width: 455px;
    }
    #Button1{
        position: fixed;
        top: 37px;
        left: 1207px;
    }
    #ddlSchoolYear {
        position: fixed;
        top: 216px;
        left: 331px;
        right: 877px;
    }
    #ddlGradeLevel {
        position: fixed;
        top: 216px;
        left: 446px;
    }
    #ddlSection {
        position: fixed;
        top: 214px;
        left: 616px;
    }
    #gvGrades {
        position: fixed;
        top: 245px;
        left: 334px;
        width: 465px;
    }
    #SGSearchLabel0 {
        position: fixed;
        top: 210px;
        left: 1018px;
        bottom: 335px;
    }
    #SGtxtStuID {
        position: fixed;
        top: 259px;
        left: 1183px;
        width: 70px;
    }
    #SGSearchLabel1 {
        position: fixed;
        top: 260px;
        left: 817px;
        }
    #SGtxtLName {
        position: fixed;
        top: 294px;
        left: 910px;
        width: 176px;
    }
    #SGSearchLabel2 {
        position: fixed;
        top: 334px;
        left: 842px;
        }
    #SGtxtFName {
        position: fixed;
        top: 259px;
        left: 910px;
        width: 176px;
    }
    #SGSearchLabel3 {
        position: fixed;
        top: 295px;
        left: 819px;
        }
    #ddlQuarter {
        position: fixed;
        top: 335px;
        left: 910px;
    }
    #SGSearchLabel4 {
        position: fixed;
        top: 371px;
        left: 841px;
        bottom: 174px;
    }
    #SGtxtGrades {
        position: fixed;
        top: 370px;
        left: 911px;
        width: 70px;
    }
    #cbINC {
        position: fixed;

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
    <div class="set-grades-container">
        <asp:Label ID="TSetGradesLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="20pt" ForeColor="#983939">Set Grades</asp:Label>
        <asp:Button ID="SGAddRecord" runat="server" Text="+ Add Record" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        <asp:Button ID="SGButton1" runat="server" Text="Button 1" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        <asp:Button ID="SGButton2" runat="server" Text="Button 2" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        <asp:Label ID="SGSearchLabel" runat="server" Font-Names="Arial" ForeColor="#983939">Student ID:</asp:Label>
        <asp:TextBox ID="SGSearchTxt" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <div class="set-grades-table">
            <asp:GridView ID="gvGrades" runat="server" Height="235px">
            </asp:GridView>
           
        </div>
        <div class="set-grades-form">
            <asp:Label ID="SGSearchLabel0" runat="server" Font-Names="Arial" ForeColor="#983939">Search:</asp:Label>
            <asp:TextBox ID="SGtxtStuID" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGSearchLabel1" runat="server" Font-Names="Arial" ForeColor="#983939">First Name:</asp:Label>
            <asp:TextBox ID="SGtxtLName" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGSearchLabel2" runat="server" Font-Names="Arial" ForeColor="#983939">Quarter:</asp:Label>
            <asp:TextBox ID="SGtxtFName" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGSearchLabel3" runat="server" Font-Names="Arial" ForeColor="#983939">Last Name:</asp:Label>
            <asp:Label ID="SGSearchLabel4" runat="server" Font-Names="Arial" ForeColor="#983939">Grades:</asp:Label>
            <asp:TextBox ID="SGtxtGrades" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:DropDownList ID="ddlQuarter" runat="server">
            </asp:DropDownList>
        </div>
        <asp:Button ID="SGNext" runat="server" Text="Next" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        <asp:Button ID="SGPrev" runat="server" Text="Prev" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        <asp:DropDownList ID="ddlSchoolYear" runat="server" Width="77px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlGradeLevel" runat="server">
            <asp:ListItem>Select Grade Level</asp:ListItem>  
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSection" runat="server">
        </asp:DropDownList>
    </div>
     </form>
</body>
<%--<asp:Image ID="SetCriteriaIcon" img src="../imgs/icon-park_mail-review.png" runat="server" Height="40px" />
<asp:Label ID="SetCriteriaLabel" runat="server" Text="Set Criteria" Font-Size="14pt"></asp:Label>--%>