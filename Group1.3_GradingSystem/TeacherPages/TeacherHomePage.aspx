<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherHomePage.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherHomePage" %>

<!DOCTYPE html>
<head runat="server">
    <title>Teacher Home</title>
    <link href="../Library/css/teacher.css" rel="stylesheet" />
    <link href="../Library/css/teacher-records.css" rel="stylesheet" />
</head>
<form id="form1" runat="server">
        <asp:Image ID="Image1" img src="../imgs/HopeLogo_TransparentPng.png" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="HOPE INTEGRATED SCHOOL" Font-Bold="False" Font-Size="16pt" Width="204px" Font-Names="Times New Roman"></asp:Label>
        <asp:Image ID="UserIcon" img src="../imgs/ProfileIcon1.png" runat="server" />          
        <asp:Button ID="Button1" runat="server" OnClientClick="return confirm('Logout?');" Text="Logout" OnClick="Button1_Click" />          
<body style="height: 584px; width:1277px; margin-left: 10px;">
    <div class="teacher-side-bar">
        <asp:HyperLink ID="TeacherHomeHL" runat="server" NavigateUrl="TeacherHomePage.aspx" Font-Size="14pt" Font-Underline="False"> <asp:Image ID="HomeIcon" img src="../imgs/icon_home.png" runat="server" Height="40px" />
        </asp:HyperLink>  
    <asp:HyperLink ID="TeacherHomeLabel" runat="server" NavigateUrl="TeacherHomePage.aspx" Text="Home" Font-Size="14pt" Font-Underline="False"></asp:HyperLink>
    <asp:HyperLink ID="SetGradesHL" runat="server" NavigateUrl="TeacherGradesPage.aspx" Font-Size="14pt" Font-Underline="False"> <asp:Image ID="SetGradesIcon" runat="server" img="" src="../imgs/ic_sharp-rate-review.png" />
        </asp:HyperLink> 
        <asp:HyperLink ID="RecordsHL" runat="server" NavigateUrl="TeacherRecords.aspx" Font-Size="14pt" Text="Records" Font-Underline="False"> 
            <asp:Image ID="RecordsIcon" runat="server" src="../imgs/icon-park_mail-review.png" />
        </asp:HyperLink>
        <asp:HyperLink ID="SetGradesLabel" runat="server" NavigateUrl="TeacherGradesPage.aspx" Font-Size="14pt" Text="Grades" Font-Underline="False"></asp:HyperLink>
    </div>
    <div class="teacher-home-image">
        <asp:Label ID="TeacherWelcomeLabel" runat="server" Font-Names="Arial" Font-Size="30pt">Welcome, </asp:Label>
        <asp:Label ID="TeacherUser" runat="server" Font-Names="Arial" Font-Size="30pt" Text="Teacher User"></asp:Label>
        <asp:Image ID="TeacherWelcome" img src="../imgs/Graphic1.png" runat="server" Height="525px" Width="948px" />
        </div>
    </form>
</body>
