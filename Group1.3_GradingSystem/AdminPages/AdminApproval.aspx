<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminApproval.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminApproval" %>

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
        top: 407px;
        left: 141px;
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
    
    </style>
</head>
<body style="height: 615px">
    <form id="form1" runat="server">
        <div style="height: 615px">
    
        <div>
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
    
    
        <div style="height: 570px">
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
            <asp:Label ID="Label13" runat="server" Text="/  Manage Admin Approval" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label12" runat="server" Text="/  Subjects" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="/          Dashboard" Font-Names="Arial" ForeColor="#B03E3E" Font-Size="7pt"></asp:Label>
            <asp:Label ID="Label11" runat="server" Text="Home      " Font-Names="Arial" ForeColor="#B03E3E" Font-Size="7pt"></asp:Label>



        </div>

        </div>

    </form>

</body>

</html>