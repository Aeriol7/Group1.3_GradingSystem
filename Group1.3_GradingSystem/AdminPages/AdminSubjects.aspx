<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSubjects.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminSubjects" enableEventValidation="false"%>

<!DOCTYPE html>
<head runat="server">
    <title>Manage Subjects</title>
    <link href="../Library/css/admin.css" rel="stylesheet" />
    <link href="../Library/css/admin-subjects.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form2" runat="server">
                <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" />
                <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman" Font-Size="16pt"></asp:Label>
                <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
                <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" OnClientClick="return confirm('Logout');" BackColor="White" ForeColor="#983939"/>
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

        <div class="admin-subjects-container">
            <asp:Label ID="AManageSubjectsLabel" runat="server" ForeColor="#B03E3E" Text="Manage Subjects" Font-Names="Arial" Font-Size="20pt"></asp:Label>            
                <div class="admin-subject">
            <asp:GridView OnSelectedIndexChanged="gvSubjects_SelectedIndexChanged" OnRowDataBound="gvSubjects_RowDataBound" OnPageIndexChanging="OnPageIndexChangingsubjects" ID="gvSubjects" runat="server"  CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4">
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
            <div class="admin-teacher" >
            <asp:GridView  OnRowDataBound="gvTeachers_RowDataBound"  ID="gvTeachers" runat="server" CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="4" Height="142px" >
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
                 <asp:TextBox ID="AtxtSubjectID" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="AtxtSubjectName" runat="server"></asp:TextBox>
                <asp:Label ID="ASubjectIDLabel" runat="server" Text="Subject ID:"></asp:Label>
                <asp:Label ID="ATeacherIDLabel" runat="server" Text="Teacher ID:"></asp:Label>
                <asp:Label ID="AYearLevelLabel" runat="server" Text="Year Level:"></asp:Label>
                <asp:Label ID="ASubjectNameLabel" runat="server" Text="Subject Name:"></asp:Label>
            <asp:Button ID="AbtnAddSubject" runat="server" Text="Add" Height="29px" Width="96px" OnClick="AbtnAddSubject_Click" OnClientClick="return confirm('Add Subject?');" BackColor="White" ForeColor="#983939"/>
            <asp:Button ID="AbtnUpdateSubject" runat="server" Text="Update" Width="96px" OnClick="AbtnUpdateSubject_Click" Height="29px" OnClientClick="return confirm('Update Subject?');" BackColor="White" ForeColor="#983939"/>
            <asp:Button ID="AbtnDeleteSubject" runat="server" Text="Delete" Width="96px" Height="29px" OnClick="AbtnDeleteSubject_Click" OnClientClick="return confirm('Delete Subject?');" BackColor="White" ForeColor="#983939"/>
            <asp:Button ID="AbtnClearSubject" runat="server" Text="Clear" Width="96px" Height="29px" OnClick="AbtnClearSubject_Click" BackColor="White" ForeColor="#983939" />
                    <asp:DropDownList ID="AddlCategory" runat="server" Height="25px" Width="167px">
                        <asp:ListItem Value="0">Select Category</asp:ListItem>
                        <asp:ListItem Value="1">Language, AP, EsP</asp:ListItem>
                        <asp:ListItem Value="2">Science, Math</asp:ListItem>
                        <asp:ListItem Value="3">MAPEH, EPP/TLE</asp:ListItem>
                        <asp:ListItem Value="4">Academic Subject</asp:ListItem>
                        <asp:ListItem Value="5">Research, Work Immersion</asp:ListItem>
                       </asp:DropDownList>       
            <asp:DropDownList ID="AddlYearLevel" runat="server" Height="25px" Width="167px">
                <asp:ListItem>Select Year Level</asp:ListItem>
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
            <asp:Label ID="ACategoryLabel" runat="server" Text="Category:"></asp:Label>          
            <asp:TextBox ID="AtxtTeacherID" runat="server"></asp:TextBox>            
            </div>
    </form>   
</body>