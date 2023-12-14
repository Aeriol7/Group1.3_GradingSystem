<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminHome" %>

<!DOCTYPE html>
<head runat="server">
    <title>Admin Home</title>
    <link href="../Library/css/admin.css" rel="stylesheet" />
    <link href="../Library/css/admin-home.css" rel="stylesheet" />
</head>
<body style="height: 633px; margin-bottom: 0px; margin-top: 0px;">
       <form id="form2" runat="server">
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman" Font-Size="16pt"></asp:Label>
            <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button1_Click" OnClientClick="return confirm('Logout');" BackColor="White" ForeColor="#983939"/>
            <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
        <div class="admin-side-bar">
            <asp:HyperLink ID="ASubj" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx" Text="Subjects" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AFaculty" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx" Text="Faculty" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AStudent" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx" Text="Students" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt" Height="24px"></asp:HyperLink>
            <asp:HyperLink ID="ASection" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx" Text="Sections" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AApproval" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx" Text="Approval" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>  
            <asp:HyperLink ID="AHome" runat="server" NavigateUrl="AdminHome.aspx" Text="Home" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt" ></asp:HyperLink>
            <asp:hyperlink id="link" runat="server" NavigateUrl="~/AdminPages/AdminHome.aspx">
            <asp:Image ID="IHome" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" Height="45px" Width="48px" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx">
            <asp:Image ID="IBook" img src="HomeImages/🦆%20icon%20_book_.png"  runat="server" Height="45px" Width="48px" />
            </asp:hyperlink>
            <asp:hyperlink id="hyperlink3" runat="server" navigateurl="~/adminpages/adminfaculty.aspx">
            <asp:Image ID="IClipboard" img src="HomeImages/🦆%20icon%20_clipboard_.png"  runat="server" Height="45px" Width="48px" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink4" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx">
            <asp:Image ID="IPeople" img src="HomeImages/🦆%20icon%20_people_.png"  runat="server" Height="45px" Width="48px" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink5" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx">
            <asp:Image ID="IThree" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png"  runat="server" Height="45px" Width="48px" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink1" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx">
            <asp:Image ID="IApproval" img src="HomeImages/🦆%20icon%20_dashboard_.png" runat="server" Height="45px" Width="48px" />
            </asp:hyperlink>               
        </div>
        <div class="admin-welcome">
           <asp:Label ID="AdminWelcomeLabel" runat="server" Text="Welcome," Font-Names="Arial" ForeColor="#B03E3E" Font-Size="30pt"></asp:Label>
           <asp:Label ID="AdminUser" runat="server" Font-Names="Arial" ForeColor="#33CC33" Font-Size="30pt"></asp:Label>
           <asp:Image ID="AdminWelcome" img src="HomeImages/Graphic1.png"  runat="server" />
        </div>
    </form>
</body>