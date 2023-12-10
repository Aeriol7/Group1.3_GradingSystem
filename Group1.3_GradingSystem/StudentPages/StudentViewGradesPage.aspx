<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewGradesPage.aspx.cs" Inherits="Group1._3_GradingSystem.StudentPages.StudentViewGradesPage" %>

<!DOCTYPE html>
<head runat="server">
    <title>Student Grades</title>
    <link href="../Library/css/student.css" rel="stylesheet" />
</head>
<form id="form1" runat="server">
            <asp:Image ID="Image1" img src="../imgs/HopeLogo_TransparentPng.png" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="HOPE INTEGRATED SCHOOL" Font-Bold="False" Font-Size="16pt" Width="204px" Font-Names="Times New Roman"></asp:Label>
            <asp:Image ID="UserIcon" img src="../imgs/ProfileIcon1.png" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
<body style="height: 523px; width:1440px;"> 
    <div class="student-side-bar">
    <asp:HyperLink ID="StudentHomeHL"  runat="server" NavigateUrl="StudentHomePage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="HomeIcon" img src="../imgs/icon_home.png" runat="server" Height="40px" />
        </asp:HyperLink>
    <asp:HyperLink ID="StudentHomeLabel"  runat="server" NavigateUrl="StudentHomePage.aspx" Font-Size="14pt" Font-Underline="False">Home</asp:HyperLink>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">
        <asp:Image ID="ViewGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
        </asp:HyperLink>
        </div>
    <asp:HyperLink ID="ViewGradesLabel" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">View Grades</asp:HyperLink>
    <div class="set-grades-container">
        <asp:Label ID="lblStudentName" runat="server"></asp:Label>
        <asp:Label ID="SViewGradesLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="20pt" ForeColor="#983939">View Grades</asp:Label>
        <div class="view-grades-table">
            <asp:Label ID="SNotYetReleased" runat="server"></asp:Label>
            <asp:GridView ID="gvGrades" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" OnPageIndexChanging="OnPageIndexChanging" OnRowDataBound="gvGrades_RowDataBound" PageSize="8">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
        <asp:Label ID="lblSection" runat="server" Text="Grade &amp; Section:"></asp:Label>
        <asp:Label ID="lblStudentSection" runat="server" style="left: 752px"></asp:Label>
    </div>
     </form>
</body>
