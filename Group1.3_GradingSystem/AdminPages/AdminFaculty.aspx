<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminFaculty.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminFaculty" EnableEventValidation="false" %>

<!DOCTYPE html>
<head runat="server">
    <title>Manage Faculty</title>
    <link href="../Library/css/admin.css" rel="stylesheet" />
    <link href="../Library/css/admin-faculty.css" rel="stylesheet" />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>

<body style="height: 619px; width: 1262px;">

    <form id="form2" runat="server">
        <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman" Font-Size="16pt"></asp:Label>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
        <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" OnClientClick="return confirm('Logout?');" BackColor="White" ForeColor="#983939" />
        <div class="admin-side-bar">
            <asp:HyperLink ID="ASubj" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx" Text="Subjects" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AFaculty" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx" Text="Faculty" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AStudent" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx" Text="Students" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt" Height="24px"></asp:HyperLink>
            <asp:HyperLink ID="ASection" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx" Text="Sections" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AApproval" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx" Text="Approval" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="AHome" runat="server" NavigateUrl="AdminHome.aspx" Text="Home" ForeColor="#B03E3E" Font-Underline="False" Font-Size="14pt"></asp:HyperLink>
            <asp:HyperLink ID="link" runat="server" NavigateUrl="~/AdminPages/AdminHome.aspx">
                <asp:Image ID="IHome" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" Height="45px" Width="48px" />
            </asp:HyperLink>
            <asp:HyperLink ID="Hyperlink2" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx">
                <asp:Image ID="IBook" img src="HomeImages/🦆%20icon%20_book_.png" runat="server" Height="45px" Width="48px" />
            </asp:HyperLink>
            <asp:HyperLink ID="hyperlink3" runat="server" NavigateUrl="~/adminpages/adminfaculty.aspx">
                <asp:Image ID="IClipboard" img src="HomeImages/🦆%20icon%20_clipboard_.png" runat="server" Height="45px" Width="48px" />
            </asp:HyperLink>
            <asp:HyperLink ID="Hyperlink4" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx">
                <asp:Image ID="IPeople" img src="HomeImages/🦆%20icon%20_people_.png" runat="server" Height="45px" Width="48px" />
            </asp:HyperLink>
            <asp:HyperLink ID="Hyperlink5" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx">
                <asp:Image ID="IThree" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png" runat="server" Height="45px" Width="48px" />
            </asp:HyperLink>
            <asp:HyperLink ID="Hyperlink1" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx">
                <asp:Image ID="IApproval" img src="HomeImages/🦆%20icon%20_dashboard_.png" runat="server" Height="45px" Width="48px" />
            </asp:HyperLink>
        </div>
        <div class="admin-faculty-container">
            <asp:Label ID="AManageFacultyLabel" runat="server" ForeColor="#B03E3E" Text="Manage Faculty Members" Font-Names="Arial" Font-Size="20pt"></asp:Label>
            <asp:TextBox ID="AtxtLastName" runat="server"></asp:TextBox>
            <div class="admin-users">
                <asp:GridView OnSelectedIndexChanged="gvUsers_SelectedIndexChanged" OnRowDataBound="gvUsers_RowDataBound" OnPageIndexChanging="OnPageIndexChanging" ID="gvUsers" runat="server" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4">
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
                <asp:TextBox ID="AtxtUserName" runat="server"></asp:TextBox>
                <asp:TextBox ID="AtxtUserID" runat="server" Width="42px" Enabled="False" AutoPostBack="True"></asp:TextBox>
                <asp:TextBox ID="AtxtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="APasswordLabel" runat="server" Text="Password:"></asp:Label>
                <asp:Label ID="AUserIDLabel" runat="server" Text="User ID:"></asp:Label>
                <asp:Button ID="ADeleteUserbtn" runat="server" Text="Delete" OnClick="ADeleteUserbtn_Click" OnClientClick="return confirm('Delete user account?');" BackColor="White" ForeColor="#983939" />
                <asp:Button ID="AUpdateUserbtn" runat="server" Text="Update" OnClick="AUpdateUserbtn_Click" OnClientClick="return confirm('Update user account information?');" BackColor="White" ForeColor="#983939" />
                <asp:Button ID="AClearUserbtn" runat="server" Text="Clear" OnClick="AClearUserbtn_Click" BackColor="White" ForeColor="#983939" />
            </div>
            <asp:TextBox ID="AtxtFirstName" runat="server"></asp:TextBox>
            <asp:Label ID="ATeacherLastNameLabel" runat="server" Text="Last Name:"></asp:Label>

            <div class="teachers">
                <asp:Button ID="AbtnAddTeacher" runat="server" Text="Add " Height="29px" Width="96px" OnClick="AbtnAddTeacher_Click" OnClientClick="return confirm('Add teacher account?');" BackColor="White" ForeColor="#983939" />
                <asp:Button ID="AbtnUpdateTeacher" runat="server" Text="Update" Height="29px" Width="96px" OnClick="AbtnUpdateTeacher_Click" OnClientClick="return confirm('Update teacher account information?');" BackColor="White" ForeColor="#983939" />
                <asp:Button ID="AbtnDeleteTeacher" runat="server" Text="Delete" Height="29px" Width="96px" OnClick="AbtnDeleteTeacher_Click" OnClientClick="return confirm('Delete teacher account?');" BackColor="White" ForeColor="#983939" />
                <asp:Button ID="AbtnClearTeacher" runat="server" Text="Clear" Height="29px" Width="96px" OnClick="AbtnClearTeacher_Click" BackColor="White" ForeColor="#983939" />
                <asp:GridView OnSelectedIndexChanged="gvTeachers_SelectedIndexChanged" OnRowDataBound="gvTeachers_RowDataBound" OnPageIndexChanging="OnPageIndexChangingTeacher" ID="gvTeachers" runat="server" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4">
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
            <asp:TextBox ID="AtxtTeacherUserID" runat="server" Width="42px" Enabled="False"></asp:TextBox>
            <asp:Label ID="ATeacherFirstNameLabel" runat="server" Text="First Name:"></asp:Label>
            <asp:Label ID="ATeacherUserIDLabel" runat="server" Text="User ID:"></asp:Label>
            <asp:Button ID="AAddUserbtn" runat="server" Text="Add " OnClick="AAddUserbtn_Click" OnClientClick="return confirm('Add user account?');" BackColor="White" ForeColor="#983939" />
            <asp:Label ID="AUserNameLabel" runat="server" Text="Username:"></asp:Label>
            <asp:DropDownList ID="AddlUserLevel" runat="server">
                <asp:ListItem Value="0">Select User Level</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Teacher</asp:ListItem>
                <asp:ListItem Value="Student">Student</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="AUserLevelLabel" runat="server" Text="User Level:" Style="top: 461px; left: 365px"></asp:Label>
            <asp:Label ID="AConfirmPasswordLabel" runat="server" Text="Confirm Password:"></asp:Label>
            <asp:TextBox ID="AtxtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </form>
</body>
