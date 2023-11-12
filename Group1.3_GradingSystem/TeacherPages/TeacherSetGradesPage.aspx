<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherSetGradesPage.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherSetGradesPage" enableEventValidation="false" %>

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
        height: 824px;
    }
    .nav-tree-view {
        height: 379px;
        width: 254px;
    }
    .set-grades-container {
        position: fixed;
        top: 85px;
        left: 318px;
        width: 960px;
        height: 696px;
    }
    #TSetGradesLabel {
        position: fixed;
        top: 88px;
        left: 328px;
        height: 40px;
        width: 197px;
    }
    #SGSaveGrades {
        position: fixed;
        top: 513px;
        left: 655px;
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
    #SGStudIDLabel {
        position: fixed;
        top: 483px;
        left: 624px;
        bottom: 16px;
    }
    #SGSearchTxt {
        position: fixed;
        top: 138px;
        left: 1084px;
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
        top: 164px;
        left: 337px;
        width: 931px;
        height: 303px;
        max-height: 303px;
        overflow-y: scroll;
    }
    .set-grades-form {
        position: fixed;
        top: 474px;
        left: 340px;
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
        top: 135px;
        left: 334px;
        width: 79px;
        height: 15px;
    }
    #ddlGradeLevel {
        position: fixed;
        top: 135px;
        left: 456px;
        }
    #ddlSection {
        position: fixed;
        top: 135px;
        left: 582px;
    }
    #ddlSubjects {
        position: fixed;
        top: 135px;
        left: 741px;
    }
    #gvGrades {
        position: fixed;
        top: 168px;
        left: 340px;
        width: 924px;
        max-height: 291px;
        overflow-y: scroll;
        height: 291px;
    }
    #SGSearchLabel0 {
        position: fixed;
        top: 139px;
        left: 1018px;
        bottom: 381px;
    }
    #SGtxtStuID {
        position: fixed;
        top: 483px;
        left: 706px;
        width: 70px;
    }
    #SGFNLabel {
        position: fixed;
        top: 483px;
        left: 350px;
        }
    #SGtxtLName {
        position: fixed;
        top: 512px;
        left: 434px;
        width: 176px;
    }
    #SGQRTLabel {
        position: fixed;
        top: 540px;
        left: 374px;
        right: 855px;
    }
    #SGtxtFName {
        position: fixed;
        top: 484px;
        left: 434px;
        width: 176px;
    }
    #SGLNLabel {
        position: fixed;
        top: 512px;
        left: 350px;
        }
    #ddlQuarter {
        position: fixed;
        top: 305px;
        left: 943px;
    }
    #SGGradesLabel {
        position: fixed;
        top: 569px;
        left: 373px;
    }
    #SGtxtGrades {
        position: fixed;
        top: 569px;
        left: 434px;
        width: 70px;
    }
    #cbINC {
        position: fixed;

    }
    #SGtxtQuarter {
        position: fixed;
        top: 541px;
        left: 434px;
        width: 70px;
    }
    #ddlSection0 {
        position: fixed;
        top: 135px;
        left: 570px;
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
<body style="height: 823px; width:1440px;"> 
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
        <asp:Label ID="SGSearchLabel0" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Search:</asp:Label>
        <asp:TextBox ID="SGSearchTxt" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <asp:DropDownList ID="ddlSchoolYear" runat="server" Width="85px" Height="22px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlGradeLevel" runat="server" Width="105px" Height="22px" AutoPostBack = "true" OnSelectedIndexChanged="ddlGradeLevel_SelectedIndexChanged">
            <asp:ListItem >Select Grade</asp:ListItem>
            <asp:ListItem Value="1">Kinder</asp:ListItem>
            <asp:ListItem>Grade 1</asp:ListItem>
            <asp:ListItem>Grade 2</asp:ListItem>
            <asp:ListItem>Grade 3</asp:ListItem>
            <asp:ListItem>Grade 4</asp:ListItem>
            <asp:ListItem>Grade 5</asp:ListItem>
            <asp:ListItem>Grade 6</asp:ListItem>
            <asp:ListItem>Grade 7</asp:ListItem>
            <asp:ListItem>Grade 8</asp:ListItem>
            <asp:ListItem>Grade 9</asp:ListItem>
            <asp:ListItem>Grade 10</asp:ListItem>
            <asp:ListItem>Grade 11</asp:ListItem>
            <asp:ListItem>Grade 12</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSection" runat="server" Height="22px" Width="125px" Enabled="False">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSubjects" runat="server" Height="22px" Width="125px" Enabled="False">
        </asp:DropDownList>
        <div class="set-grades-table" style="height: 303px; overflow: auto;" >
            <asp:GridView ID="gvGrades" runat="server" AllowPaging="True" PageSize="5" OnPageIndexChanging="OnPageIndexChanging" OnSelectedIndexChanged="gvGrades_SelectedIndexChanged"
    OnRowDataBound="gvGrades_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
        <div class="set-grades-form">
            <asp:Label ID="SGFNLabel" runat="server" Font-Names="Arial" ForeColor="#983939">First Name:</asp:Label>
            <asp:TextBox ID="SGtxtFName" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGLNLabel" runat="server" Font-Names="Arial" ForeColor="#983939" BorderStyle="None">Last Name:</asp:Label>
            <asp:TextBox ID="SGtxtLName" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGStudIDLabel" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Student ID:</asp:Label>
            <asp:TextBox ID="SGtxtStuID" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGQRTLabel" runat="server" Font-Names="Arial" ForeColor="#983939">Quarter:</asp:Label>
            <asp:TextBox ID="SGtxtQuarter" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGGradesLabel" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Grades:</asp:Label>
            <asp:TextBox ID="SGtxtGrades" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Button ID="SGSaveGrades" runat="server" Text="Save" BackColor="White" Font-Names="Arial" ForeColor="#983939" />
        </div>
    </div>
     </form>
</body>