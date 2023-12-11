<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminApproval.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminApproval" enableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

    #Image1{
    position: fixed;
    top: 26px;
    left: 30px;
}
#Image2{
    position: fixed;
    top: 49px;
    left: 1130px;
    height: 32px;
    width: 33px;
}
#Label1{
    position: fixed;
    top: 43px;
    left: 145px;
    width: 259px;
}
#AHome{
    position: fixed;
        top: 183px;
        left: 141px;
    }
#ASubj{
    position: fixed;
        top: 228px;
        left: 140px;
    }
#AFaculty{
    position: fixed;
        top: 272px;
        left: 141px;
        height: 24px;
    }
#AStudent{
    position: fixed;
        top: 315px;
        left: 140px;
        bottom: 444px;
    }
#ASection{
position: fixed;
    top: 359px;
    left: 139px;
}
#AApproval{
    position: fixed;
        top: 402px;
        left: 134px;
    }
#IHome{
    position: fixed;
        top: 178px;
        left: 83px;
        height: 27px;
        width: 29px;
    }
#IBook{
    position: fixed;
        top: 227px;
        left: 84px;
        height: 27px;
        width: 25px;
    }
#IClipboard{
    position: fixed;
        top: 272px;
        left: 86px;
        height: 27px;
        width: 24px;
    }
#IPeople{
    position: fixed;
        top: 315px;
        left: 85px;
        height: 29px;
        width: 28px;
    }
#IThree{
   position: fixed;
        top: 360px;
        left: 87px;
        height: 26px;
        width: 26px;
    }
#IApproval{
    position: fixed;
        top: 407px;
        left: 85px;
        height: 24px;
        width: 23px;
    }
#Image10{
    position: fixed;
        top: 522px;
        left: 85px;
        height: 30px;
        width: 27px;
    }
#Image11{
    position: fixed;
        top: 96px;
        left: 278px;
        height: 479px;
        width: 985px;
    }
#Button1{
    position: fixed;
        top: 51px;
        left: 1175px;
    }
#Image10{
    position: fixed;
        top: 522px;
        left: 85px;
        height: 30px;
        width: 27px;
    }
#Image11{
    position: fixed;
        top: 96px;
        left: 278px;
        height: 479px;
        width: 985px;
    }
#Label12{
    position: fixed;
        top: 114px;
        left: 354px;
    }
#Label13{
    position: fixed;
        top: 115px;
        left: 475px;
    }
#Label14{
    position: fixed;
        top: 145px;
        left: 310px;
    }
    #Label11{
    position: fixed;
        top: 113px;
        left: 314px;
    }
#Label10{
    position: fixed;
        top: 114px;
        left: 403px;
    }
.Grade{
    position: fixed;
            top: 168px;
            left: 260px;
            width: 986px;
            height: 515px;
        }
    
    #gvGrades {
        position: fixed;
        top: 256px;
        left: 291px;
        width: 924px;
        max-height: 291px;
        overflow-y: scroll;
        height: 240px;
    }

        
    #ddlSchoolYear {
        position: fixed;
        top: 192px;
        left: 307px;
        width: 104px;
        height: 15px;
    }
    #ddlSubject{
        position: fixed;
        top: 190px;
        left: 1062px;
        }
    #ddlTeacher {
        position: fixed;
        top: 191px;
        left: 474px;
        }
    #ddlSection {
        position: fixed;
        top: 190px;
        left: 881px;
            width: 119px;
        }
    #ddlGradeLevel {
        position: fixed;
        top: 191px;
        left: 671px;
            width: 136px;
            right: 470px;
        }
    #TBLastname{
        position: fixed;
            top: 619px;
            left: 395px;
            right: 714px;
        }
        
    #TBGradeID{
        position: fixed;
            top: 525px;
            left: 397px;
            right: 712px;
        }
        
    #TBFirstname{
        position: fixed;
            top: 571px;
            left: 396px;
            right: 713px;
        }
    #LGradeid{
        position: fixed;
            top: 525px;
            left: 311px;
        }
    #LFN{
        position: fixed;
            top: 573px;
            left: 307px;
        }
    #LLN{
        position: fixed;
            top: 622px;
            left: 308px;
        }
    #DDLApprove{
        position: fixed;
            top: 524px;
            left: 633px;
        }
    #BSave{
        position: fixed;
            top: 593px;
            left: 651px;
        }
    </style>
</head>
<body style="height: 693px">
    <form id="form1" runat="server">
        <div style="height: 687px">
    
        <div>
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" OnClientClick="return confirm('Logout?');"/>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
    
    
        <div style="height: 664px">
            <asp:HyperLink ID="AHome" runat="server" NavigateUrl="AdminHome.aspx" Text="Home" ForeColor="#B03E3E" Font-Underline="False" ></asp:HyperLink>
            <asp:HyperLink ID="ASubj" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx" Text="Subjects" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="AFaculty" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx" Text="Faculty" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="AStudent" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx" Text="Students" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="ASection" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx" Text="Sections" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="AApproval" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx" Text="Approval" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>

            <asp:hyperlink id="link" runat="server" NavigateUrl="~/AdminPages/AdminHome.aspx">
            <asp:Image ID="IHome" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx">
            <asp:Image ID="IBook" img src="HomeImages/🦆%20icon%20_book_.png"  runat="server" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink3" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx">
            <asp:Image ID="IClipboard" img src="HomeImages/🦆%20icon%20_clipboard_.png"  runat="server" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink4" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx">
            <asp:Image ID="IPeople" img src="HomeImages/🦆%20icon%20_people_.png"  runat="server" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink5" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx">
            <asp:Image ID="IThree" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png"  runat="server" />
            </asp:hyperlink>
            <asp:hyperlink id="Hyperlink1" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx">
            <asp:Image ID="IApproval" img src="HomeImages/🦆%20icon%20_dashboard_.png" runat="server" />
            </asp:hyperlink>

            <asp:Label ID="Label14" runat="server" ForeColor="#B03E3E" Text="Manage Admin Approval" Font-Names="Arial" Font-Size="17pt"></asp:Label>

        </div>

        </div>

        <div = class = "Grade">


                <asp:GridView ID="gvGrades" runat="server" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" OnSelectedIndexChanged="gvGrades_SelectedIndexChanged"
                 OnRowDataBound="gvGrades_RowDataBound"  PageSize="5" CellPadding="4" ForeColor="#333333" GridLines="None">
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


            <asp:DropDownList ID="ddlSchoolYear" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="ddlSchoolYear_SelectedIndexChanged">
            <asp:ListItem Value="0">Select S.Y</asp:ListItem>
            <asp:ListItem Value="1">2023-2024</asp:ListItem>
            <asp:ListItem Value="2">2024-2025</asp:ListItem>
            <asp:ListItem Value="3">2025-2026</asp:ListItem>
            <asp:ListItem Value="4">2026-2027</asp:ListItem>
            <asp:ListItem Value="5">2027-2028</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlSubject" runat="server" Width="135px" Height="22px" AutoPostBack = "true" Enabled="False" OnSelectedIndexChanged="ddlSubject_SelectedIndexChanged">
            <asp:ListItem Value="0">Select Subject</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlTeacher" runat="server" Width="144px" Height="22px" AutoPostBack = "true" Enabled="False" OnSelectedIndexChanged="ddlTeacher_SelectedIndexChanged">
            <asp:ListItem Value="0">Select Teacher</asp:ListItem>
            </asp:DropDownList>


            <asp:DropDownList ID="ddlSection" runat="server" Height="22px" AutoPostBack = "true" Enabled="False" OnSelectedIndexChanged="ddlSection_SelectedIndexChanged" Width="135px">
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
            <asp:Label ID="LLN" runat="server" Text="Lastname:"></asp:Label>
            
            
            <asp:DropDownList ID="DDLApprove" runat="server" OnSelectedIndexChanged="DDLApprove_SelectedIndexChanged">
                <asp:ListItem Value="0">Select Status</asp:ListItem>
                <asp:ListItem Value="1">Approved</asp:ListItem>
                <asp:ListItem Value="2">Declined</asp:ListItem>
                <asp:ListItem Value="3">Pending</asp:ListItem>
            </asp:DropDownList>
            
            <asp:Button ID="BSave" runat="server" Text="Update" OnClick="BSave_Click1" OnClientClick="return confirm('Update Status?');" />


        </div>

    </form>

</body>

</html>