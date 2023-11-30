<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherRecords.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherRecords" enableEventValidation="false" %>

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
        height: 583px;
    }
    .nav-tree-view {
        height: 379px;
        width: 254px;
    }
    .set-grades-container {
        position: fixed;
        top: 85px;
        left: 316px;
        width: 960px;
        height: 517px;
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
        top: 537px;
        left: 1150px;
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
    #SRRecordIDLabel {
        position: fixed;
        top: 426px;
        left: 356px;
        bottom: 94px;
    }
    #SGSearchTxt {
        position: fixed;
        top: 90px;
        left: 1119px;
        width: 144px;
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
        top: 420px;
        left: 341px;
        height: 169px;
        width: 924px;
    }
    #Button1{
        position: fixed;
        top: 37px;
        left: 1207px;
    }
    #ddlSchoolYear {
        position: fixed;
        top: 135px;
        left: 338px;
        width: 93px;
        height: 18px;
    }
    #ddlGradeLevel {
        position: fixed;
        top: 134px;
        left: 445px;
        }
    #ddlSection {
        position: fixed;
        top: 133px;
        left: 565px;
    }
    #ddlSubjects {
        position: fixed;
        top: 132px;
        left: 717px;
        right: 443px;
    }
    #gvRecords {
        position: fixed;
        top: 170px;
        left: 339px;
        width: 924px;
        max-height: 291px;
        overflow-y: scroll;
        height: 240px;
    }
    #SGSearchLabel0 {
        position: fixed;
        top: 91px;
        left: 1058px;
        bottom: 454px;
    }
    #SRtxtRecordID {
        position: fixed;
        top: 426px;
        left: 433px;
        width: 70px;
        right: 776px;
    }
    #SRFNLabel {
        position: fixed;
        top: 455px;
        left: 348px;
        }
    #SRtxtLName {
        position: fixed;
        top: 478px;
        left: 433px;
        width: 176px;
    }
    #SRQRTLabel {
        position: fixed;
        top: 503px;
        left: 373px;
        right: 858px;
    }
    #SRtxtFName {
        position: fixed;
        top: 453px;
        left: 433px;
        width: 176px;
    }
    #SRLNLabel {
        position: fixed;
        top: 480px;
        left: 349px;
        }
    #ddlAmnt {
        position: fixed;
        top: 305px;
        left: 943px;
    }
    #SGGradesLabel {
        position: fixed;
        top: 502px;
        left: 383px;
    }
    #SGtxtGrades {
        position: fixed;
        top: 501px;
        left: 433px;
        width: 70px;
    }
    #cbINC {
        position: fixed;

    }
    #ddlAmnt {
        position: fixed;
        top: 422px;
        left: 817px;
        width: 70px;
        right: 353px;
    }
    #ddlSection0 {
        position: fixed;
        top: 135px;
        left: 570px;
    }
#RecordsHL {
    position: fixed;
    text-align: center;
    color: #B03E3E;
    font-family: Inter;
    font-size: 100px;
    font-style: normal;
    font-weight: 700;
    line-height: normal;
    position: fixed;
    top: 283px;
    left: 148px;
}
#RecordsIcon {
    position: fixed;
    width: 48px;
    height: 45px;
    top: 273px;
    left: 39px;
}
#ddlSchoolWork{
    position: fixed;
        left: 1007px;
        height: 18px;
        width: 176px;
        top: 131px;
    }
    #SRAmntLabel {
        position: fixed;
        top: 424px;
        left: 796px;
        right: 343px;
    }
    #ddlQuarter {
        position: fixed;
        top: 131px;
        left: 873px;
        width: 70px;
    }
    #SGGradesLabel0 {
        position: fixed;
        top: 423px;
        left: 640px;
        width: 205px;
        height: 19px;
        margin-bottom: 0px;
    }
    #SRtxtTotalScore {
        position: fixed;
        top: 475px;
        left: 817px;
        width: 70px;
    }
    #SRSWNoLabel {
        position: fixed;
        top: 451px;
        left: 690px;
        bottom: 69px;
    }
    #SRTotalScoreLabel {
        position: fixed;
        top: 477px;
        left: 727px;
        bottom: 43px;
    }
    #SRtxtSWNo {
        position: fixed;
        top: 449px;
        left: 817px;
        width: 70px;
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
<body style="height: 584px; width:1277px; margin-left: 10px;">
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
        <asp:HyperLink ID="RecordsHL" runat="server" NavigateUrl="TeacherRecords.aspx" Font-Size="14pt" Text="Records" Font-Underline="False">
        <asp:Image ID="RecordsIcon" runat="server" src="../imgs/icon-park_mail-review.png" />
        </asp:HyperLink>
    <asp:HyperLink ID="SetGradesLabel" runat="server" NavigateUrl="TeacherSetGradesPage.aspx" Font-Size="14pt" Text="Set Grades" Font-Underline="False"></asp:HyperLink>
    <div class="set-grades-container">
        <asp:Label ID="TSetGradesLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="20pt" ForeColor="#983939">Records</asp:Label>
        <asp:Label ID="SGSearchLabel0" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Search:</asp:Label>
        <asp:TextBox ID="SGSearchTxt" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <asp:DropDownList ID="ddlGradeLevel" runat="server" Width="105px" Height="22px" AutoPostBack = "true" OnSelectedIndexChanged="ddlGradeLevel_SelectedIndexChanged">
            <asp:ListItem >Select Level</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSection" runat="server" Height="22px" Width="125px" Enabled="False" AutoPostBack = "True" OnSelectedIndexChanged="ddlSection_SelectedIndexChanged">
            <asp:ListItem>Select Section</asp:ListItem>
            <asp:ListItem>Kinder-A</asp:ListItem>
            <asp:ListItem>Grade 1-A</asp:ListItem>
            <asp:ListItem>Grade 2-A</asp:ListItem>
            <asp:ListItem>Grade 3-A</asp:ListItem>
            <asp:ListItem>Grade 4-A</asp:ListItem>
            <asp:ListItem>Grade 5-A</asp:ListItem>
            <asp:ListItem>Grade 6-A</asp:ListItem>
            <asp:ListItem>Grade 7-A</asp:ListItem>
            <asp:ListItem>Grade 8-A</asp:ListItem>
            <asp:ListItem>Grade 9-A</asp:ListItem>
            <asp:ListItem>Grade 10-A</asp:ListItem>
            <asp:ListItem>Grade 11-HUMSS</asp:ListItem>
            <asp:ListItem>Grade 11-STEM</asp:ListItem>
            <asp:ListItem>Grade 12-HUMSS</asp:ListItem>
            <asp:ListItem>Grade 12-STEM</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSubjects" runat="server" Height="22px" Width="125px" Enabled="False"  AutoPostBack = "true" OnSelectedIndexChanged="ddlSubjects_SelectedIndexChanged">
            <asp:ListItem>Select Subject</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSchoolWork" runat="server" AutoPostBack="True" Height="22px" OnSelectedIndexChanged="ddlSchoolWork_SelectedIndexChanged" Enabled="False">
            <asp:ListItem>Select School Work Type</asp:ListItem>
            <asp:ListItem Value="1">Written Work</asp:ListItem>
            <asp:ListItem Value="2">Performance Task</asp:ListItem>
            <asp:ListItem Value="3">Quarterly Assessment</asp:ListItem>
</asp:DropDownList>
        <div class="set-grades-table" style="height: 250px; overflow: auto;" >
            <asp:GridView ID="gvRecords" runat="server" AllowPaging="True" PageSize="5" OnPageIndexChanging="OnPageIndexChanging" OnSelectedIndexChanged="gvRecords_SelectedIndexChanged"
    OnRowDataBound="gvRecords_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:Label ID="SRFNLabel" runat="server" Font-Names="Arial" ForeColor="#983939">First Name:</asp:Label>
            <asp:TextBox ID="SRtxtFName" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SRLNLabel" runat="server" Font-Names="Arial" ForeColor="#983939" BorderStyle="None">Last Name:</asp:Label>
            <asp:TextBox ID="SRtxtLName" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SRRecordIDLabel" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Record ID:</asp:Label>
            <asp:TextBox ID="SRtxtRecordID" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <asp:DropDownList ID="ddlAmnt" runat="server" Width="115px" Height="22px" AutoPostBack="True">
            <asp:ListItem>Select Amount </asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
            <asp:Label ID="SGGradesLabel" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Score:</asp:Label>
            <asp:TextBox ID="SGtxtGrades" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SRTotalScoreLabel" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Total Score:</asp:Label>
            <asp:TextBox ID="SRtxtTotalScore" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Button ID="SGSaveGrades" runat="server" Text="Save" BackColor="White" Font-Names="Arial" ForeColor="#983939" OnClick="SGSaveGrades_Click" />
            <asp:Label ID="SRSWNoLabel" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">School Work No.:</asp:Label>
            <asp:TextBox ID="SRtxtSWNo" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:Label ID="SGGradesLabel0" runat="server" Font-Names="Arial" ForeColor="#983939">Amount of School Work:</asp:Label>
        </div>
        <asp:DropDownList ID="ddlSchoolYear" runat="server" Width="95px" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="ddlSchoolYear_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlQuarter" runat="server" Width="110px" Height="22px" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlQuarter_SelectedIndexChanged">
    <asp:ListItem>Select Quarter</asp:ListItem>
    <asp:ListItem Value="1">1st</asp:ListItem>
    <asp:ListItem Value="2">2nd</asp:ListItem>
    <asp:ListItem Value="3">3rd</asp:ListItem>
    <asp:ListItem Value="4">4th</asp:ListItem>
</asp:DropDownList>
    </div>
</body>
    
</form>