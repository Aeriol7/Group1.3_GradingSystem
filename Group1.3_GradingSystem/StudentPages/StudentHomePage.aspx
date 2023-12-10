<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" Inherits="Group1._3_GradingSystem.StudentPages.StudentHomePage" %>

<!DOCTYPE html>
<head runat="server">
    <title>Student Home</title>
    <link href="../Library/css/student.css" rel="stylesheet" />
</head>
<form id="form1" runat="server" height=>
            <asp:Image ID="Image1" img src="../imgs/HopeLogo_TransparentPng.png" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="HOPE INTEGRATED SCHOOL" Font-Bold="False" Font-Size="16pt" Width="204px" Font-Names="Times New Roman"></asp:Label>
            <asp:Image ID="UserIcon" img src="../imgs/ProfileIcon1.png" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
<body style="height: 584px; width:1277px; margin-left: 0px;">
    <div class="student-side-bar" height="524px;">
<asp:HyperLink ID="StudentHomeHL"  runat="server" NavigateUrl="StudentHomePage.aspx" Font-Size="14pt" Font-Underline="False">
    <asp:Image ID="HomeIcon" img src="../imgs/icon_home.png" runat="server" Height="40px" />
    </asp:HyperLink>
<asp:HyperLink ID="StudentHomeLabel"  runat="server" NavigateUrl="StudentHomePage.aspx" Font-Size="14pt" Font-Underline="False">Home</asp:HyperLink>
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">
    <asp:Image ID="ViewGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
    </asp:HyperLink>
        </div>
    <asp:HyperLink ID="ViewGradesLabel" runat="server" NavigateUrl="StudentViewGradesPage.aspx" Font-Size="14pt" Font-Underline="False">View Grades</asp:HyperLink>
        <div class="student-home-image">
        <asp:Label ID="StudentWelcomeLabel" runat="server" Font-Names="Arial" Font-Size="30pt">Welcome, </asp:Label>
        <asp:Label ID="StudentUser" runat="server" Font-Names="Arial" Font-Size="30pt">Student! </asp:Label>
        <asp:Image ID="StudentWelcome" img src="../imgs/Graphic1.png" runat="server" />
        </div>
    </form>
</body>
