<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStudent.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminStudent" enableEventValidation="false" %>

<!DOCTYPE html>
<head runat="server">
    <title>Manage Students</title>
    <link href="../Library/css/admin.css" rel="stylesheet" />
    <link href="../Library/css/admin-student.css" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
                <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" />
                <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman" Font-Size="16pt"></asp:Label>
                <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
                <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" OnClientClick="return confirm('Logout?');" BackColor="White" ForeColor="#983939"/>
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
        <div class="manage-students" style="height: 559px; width: 966px; top: 85px; left: 304px;">
            <asp:Label ID="AManageStudentLabel" runat="server" ForeColor="#B03E3E" Text="Manage Students" Font-Names="Arial" Font-Size="20pt"></asp:Label>                         
            <div class="student-table">
            <asp:GridView OnSelectedIndexChanged="gvStudents_SelectedIndexChanged" OnRowDataBound="gvStudents_RowDataBound" OnPageIndexChanging="OnPageIndexChangingstudents" ID="gvStudents" runat="server"  CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
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
            <asp:Button ID="AbtnDelete" runat="server" Text="Delete" Width="96px" Height="29px" OnClick="AbtnDelete_Click" OnClientClick="return confirm('Delete Section?');" BackColor="White" ForeColor="#983939"/>
<asp:Button ID="AbtnUpdate" runat="server" Text="Update" Width="96px" OnClick="AbtnUpdate_Click" Height="29px" OnClientClick="return confirm('Update Section?');" BackColor="White" ForeColor="#983939"/>
<asp:Button ID="AbtnClear" runat="server" Text="Clear" Width="96px" Height="29px" OnClick="AbtnClear_Click" BackColor="White" ForeColor="#983939" />
<asp:Label ID="AFirstNameLabel" runat="server" Text="First Name:"></asp:Label>
<asp:Label ID="AStudentIDLabel" runat="server" Text="Student ID:"></asp:Label>
<asp:TextBox ID="AtxtFirstName" runat="server"></asp:TextBox>
<asp:Label ID="ALastNameLabel" runat="server" Text="Last Name:"></asp:Label>
<asp:TextBox ID="AtxtStudentID" runat="server" Enabled="False"></asp:TextBox>
<asp:Button ID="AbtnAdd" runat="server" Text="Add" Height="29px" Width="96px" OnClick="AbtnAdd_Click" OnClientClick="return confirm('Add Student?');" BackColor="White" ForeColor="#983939"/>
<asp:Label ID="AUserIDLabel" runat="server" Text="User ID:"></asp:Label>
<asp:TextBox ID="AtxtLastName" runat="server"></asp:TextBox>
<asp:Label ID="AYearLevelLabel" runat="server" Text="Year Level:"></asp:Label>
<asp:TextBox ID="AtxtUserID" runat="server"></asp:TextBox>
<asp:Label ID="ASectionLabel" runat="server" Text="Section:"></asp:Label>
<asp:DropDownList ID="ddlSection" runat="server" Height="25px" Width="167px">
     <asp:ListItem Value="0">Select Section</asp:ListItem>
</asp:DropDownList>
<asp:Label ID="ASchoolYearLabel" runat="server" Text="School Year:"></asp:Label> 
<asp:DropDownList ID="ddlSchoolYear" runat="server" Height="25px">
    <asp:ListItem Value="0">Select S.Y</asp:ListItem>
    <asp:ListItem Value="1">2023-2024</asp:ListItem>
    <asp:ListItem Value="2">2024-2025</asp:ListItem>
    <asp:ListItem Value="3">2025-2026</asp:ListItem>
    <asp:ListItem Value="4">2026-2027</asp:ListItem>
    <asp:ListItem Value="5">2027-2028</asp:ListItem>
</asp:DropDownList>  
            <div class="sections">
                <asp:GridView OnRowDataBound="gvUsers_RowDataBound" OnPageIndexChanging="OnPageIndexChangingsections" ID="gvUsers" runat="server"  CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" Height="102px" OnSelectedIndexChanged="gvUsers_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
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
            <asp:DropDownList ID="ddlYearLevel" runat="server" Height="25px" Width="167px" AutoPostBack="True" OnSelectedIndexChanged="ddlYearLevel_SelectedIndexChanged">
                <asp:ListItem Value="0">Select Grade Level</asp:ListItem>
                <asp:ListItem Value="1">Kinder</asp:ListItem>
                <asp:ListItem Value="2">Grade 1</asp:ListItem>
                <asp:ListItem Value="3">Grade 2</asp:ListItem>
                <asp:ListItem Value="4">Grade 3</asp:ListItem>
                <asp:ListItem Value="5">Grade 4</asp:ListItem>
                <asp:ListItem Value="6">Grade 5</asp:ListItem>
                <asp:ListItem Value="7">Grade 6</asp:ListItem>
                <asp:ListItem Value="8">Grade 7</asp:ListItem>
                <asp:ListItem Value="9">Grade 8</asp:ListItem>
                <asp:ListItem Value="10">Grade 9</asp:ListItem>
                <asp:ListItem Value="11">Grade 10</asp:ListItem>
                <asp:ListItem Value="12">Grade 11</asp:ListItem>
                <asp:ListItem Value="13">Grade 12</asp:ListItem>
            </asp:DropDownList>
            </div>
    </form>    
</body>