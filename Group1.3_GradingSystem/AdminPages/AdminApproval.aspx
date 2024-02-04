<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminApproval.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminApproval" EnableEventValidation="false" %>

<!DOCTYPE html>
<head runat="server">
    <title>Approve Grades</title>
    <link href="../Library/css/admin.css" rel="stylesheet" />
    <link href="../Library/css/admin-approval.css" rel="stylesheet" />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>
<body style="height: 637px; margin-top: 0px; margin-bottom: 0px;">
    <form id="form2" runat="server">
        <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman" Font-Size="16pt"></asp:Label>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
        <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" OnClientClick="return confirm('Logout');" BackColor="White" ForeColor="#983939" />
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
        <div class="admin-approval-container">
            <asp:Label ID="AManageApprovalLabel" runat="server" ForeColor="#B03E3E" Text="Manage Admin Approval" Font-Names="Arial" Font-Size="20pt"></asp:Label>
            <div class="admin-grades">
                <asp:GridView ID="gvGrades" runat="server" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" OnSelectedIndexChanged="gvGrades_SelectedIndexChanged"
                    OnRowDataBound="gvGrades_RowDataBound" PageSize="4" CellPadding="4" ForeColor="#333333">
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
            <asp:DropDownList ID="ddlSchoolYear" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="ddlSchoolYear_SelectedIndexChanged">
                <asp:ListItem Value="0">Select S.Y</asp:ListItem>
                <asp:ListItem Value="1">2023-2024</asp:ListItem>
                <asp:ListItem Value="2">2024-2025</asp:ListItem>
                <asp:ListItem Value="3">2025-2026</asp:ListItem>
                <asp:ListItem Value="4">2026-2027</asp:ListItem>
                <asp:ListItem Value="5">2027-2028</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlSubject" runat="server" Width="135px" Height="22px" AutoPostBack="true" Enabled="False" OnSelectedIndexChanged="ddlSubject_SelectedIndexChanged">
                <asp:ListItem Value="0">Select Subject</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlTeacher" runat="server" Width="144px" Height="22px" AutoPostBack="true" Enabled="False" OnSelectedIndexChanged="ddlTeacher_SelectedIndexChanged">
                <asp:ListItem Value="0">Select Teacher</asp:ListItem>
            </asp:DropDownList>


            <asp:DropDownList ID="ddlSection" runat="server" Height="22px" AutoPostBack="true" Enabled="False" OnSelectedIndexChanged="ddlSection_SelectedIndexChanged" Width="135px">
                <asp:ListItem Value="0">Select Section</asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList ID="ddlGradeLevel" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlGradeLevel_SelectedIndexChanged">
                <asp:ListItem Value="0">Select Grade</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TBFirstname" runat="server" Enabled="False" Width="160px"></asp:TextBox>
            <asp:TextBox ID="TBLastname" runat="server" Enabled="False" Width="160px"></asp:TextBox>
            <asp:TextBox ID="TBGradeID" runat="server" Enabled="False" Width="160px"></asp:TextBox>
            <asp:Label ID="LGradeid" runat="server" Text="Grade ID:"></asp:Label>
            <asp:Label ID="LFN" runat="server" Text="Firstname:"></asp:Label>
            <asp:DropDownList ID="DDLApprove" runat="server">
                <asp:ListItem Value="0">Select Status</asp:ListItem>
                <asp:ListItem Value="1">Approved</asp:ListItem>
                <asp:ListItem Value="2">Declined</asp:ListItem>
                <asp:ListItem Value="3">Pending</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="BSave" runat="server" Text="Update" OnClick="BSave_Click1" OnClientClick="return confirm('Update Status?');" BackColor="White" ForeColor="#983939" />
            <asp:Label ID="LLN" runat="server" Text="Lastname:"></asp:Label>
        </div>
    </form>
</body>
