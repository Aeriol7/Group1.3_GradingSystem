<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherSetGradesPage.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherSetGradesPage" enableEventValidation="false" %>

<!DOCTYPE html>
<head runat="server">
    <title>Teacher Grades</title>
    <link href="../Library/css/teacher.css" rel="stylesheet" />
    <link href="../Library/css/teacher-grades.css" rel="stylesheet" />
</head>
<form id="form1" runat="server">
        <asp:Image ID="Image1" img src="../imgs/HopeLogo_TransparentPng.png" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="HOPE INTEGRATED SCHOOL" Font-Bold="False" Font-Size="16pt" Width="204px" Font-Names="Times New Roman"></asp:Label>
        <asp:Image ID="UserIcon" img src="../imgs/ProfileIcon1.png" runat="server" />          
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />          
<body style="height: 584px; width:1277px; margin-left: 10px;">
    <div class="teacher-side-bar">
        <asp:HyperLink ID="TeacherHomeHL" runat="server" NavigateUrl="TeacherHomePage.aspx" Font-Size="14pt" Font-Underline="False"> <asp:Image ID="HomeIcon" img src="../imgs/icon_home.png" runat="server" Height="40px" />
        </asp:HyperLink>  
    <asp:HyperLink ID="TeacherHomeLabel" runat="server" NavigateUrl="TeacherHomePage.aspx" Text="Home" Font-Size="14pt" Font-Underline="False"></asp:HyperLink>
    <asp:HyperLink ID="SetGradesHL" runat="server" NavigateUrl="TeacherSetGradesPage.aspx" Font-Size="14pt" Font-Underline="False"> <asp:Image ID="SetGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
        </asp:HyperLink> 
        <asp:HyperLink ID="RecordsHL" runat="server" NavigateUrl="TeacherRecords.aspx" Font-Size="14pt" Text="Records" Font-Underline="False"> 
            <asp:Image ID="RecordsIcon" runat="server" src="../imgs/icon-park_mail-review.png" />
        </asp:HyperLink>
    <asp:HyperLink ID="SetGradesLabel" runat="server" NavigateUrl="TeacherSetGradesPage.aspx" Font-Size="14pt" Text="Set Grades" Font-Underline="False"></asp:HyperLink>
    </div>
    <div class="set-grades-container">
        <asp:Label ID="TSetGradesLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="20pt" ForeColor="#983939">Set Grades</asp:Label>
        <asp:Label ID="SGSearchLabel0" runat="server" Font-Names="Arial" ForeColor="#983939" Height="18px">Search:</asp:Label>
        <asp:TextBox ID="SGSearchTxt" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddlSchoolYear" runat="server" Width="95px" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="ddlSchoolYear_SelectedIndexChanged">
            <asp:ListItem Value="0">Select S.Y.</asp:ListItem>
            <asp:ListItem Value="1">2023-2024</asp:ListItem>
            <asp:ListItem Value="2">2024-2025</asp:ListItem>
            <asp:ListItem Value="3">2025-2026</asp:ListItem>
            <asp:ListItem Value="4">2026-2027</asp:ListItem>
            <asp:ListItem Value="5">2027-2028</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlGradeLevel" runat="server" Width="105px" Height="22px" AutoPostBack = "true" OnSelectedIndexChanged="ddlGradeLevel_SelectedIndexChanged" Enabled="False">
            <asp:ListItem Value="0">Select Grade</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSection" runat="server" Height="22px" Width="130px" Enabled="False" AutoPostBack = "true" OnSelectedIndexChanged="ddlSection_SelectedIndexChanged">
            <asp:ListItem Value="0">Select Section</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlSubjects" runat="server" Height="22px" Width="125px" Enabled="False"  AutoPostBack = "true" OnSelectedIndexChanged="ddlSubjects_SelectedIndexChanged">
            <asp:ListItem Value="0">Select Subject</asp:ListItem>
        </asp:DropDownList>
        <div class="set-grades-table" style="height: 250px; overflow: auto;" >
            <asp:Label ID="TGNoRecordsLabel" runat="server"></asp:Label>
            <asp:GridView ID="gvGrades" runat="server" AllowPaging="True" PageSize="5" OnPageIndexChanging="OnPageIndexChanging" OnRowDataBound="gvGrades_RowDataBound" CellPadding="4" ForeColor="#333333">
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </div>
</body>
</form>