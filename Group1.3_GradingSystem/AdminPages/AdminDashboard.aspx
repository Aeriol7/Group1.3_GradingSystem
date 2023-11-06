<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminDashboard1" %>

<!DOCTYPE html>

<style>
    #Image1{
    position: fixed;
    top: 26px;
    left: 30px;
}
#Image2{
    position: fixed;
    top: 57px;
    left: 1199px;
    height: 32px;
    width: 33px;
}
#Label1{
    position: fixed;
    top: 43px;
    left: 145px;
    width: 259px;
}
#DropDownList1{
    position: fixed;
    top: 59px;
    left: 1255px;
}
#Label2{
    position: fixed;
        top: 183px;
        left: 141px;
    }
#Label3{
   position: fixed;
        top: 231px;
        left: 140px;
    }
#Label4{
    position: fixed;
        top: 283px;
        left: 141px;
    }
#Label5{
    position: fixed;
        top: 339px;
        left: 141px;
        height: 24px;
    }
#Label6{
    position: fixed;
        top: 386px;
        left: 141px;
        bottom: 167px;
    }
#Label7{
    position: fixed;
        top: 429px;
        left: 141px;
    }
#Label8{
    position: fixed;
        top: 476px;
        left: 141px;
    }
#Label9{
    position: fixed;
        top: 526px;
        left: 141px;
    }
#Label11{
    position: fixed;
        top: 143px;
        left: 537px;
        resize: 20px;
    }
#Label10{
    position: fixed;
        top: 144px;
        left: 763px;
        resize: 20px;
    }
#Image3{
    position: fixed;
        top: 178px;
        left: 83px;
        height: 27px;
        width: 29px;
    }
#Image4{
   position: fixed;
        top: 228px;
        left: 83px;
        height: 27px;
        width: 29px;
    }
#Image5{
    position: fixed;
        top: 283px;
        left: 85px;
        height: 27px;
        width: 25px;
    }
#Image6{
    position: fixed;
        top: 337px;
        left: 84px;
        height: 27px;
        width: 24px;
    }
#Image7{
    position: fixed;
        top: 385px;
        left: 84px;
        height: 29px;
        width: 28px;
    }
#Image8{
   position: fixed;
        top: 429px;
        left: 85px;
        height: 26px;
        width: 26px;
    }
#Image9{
    position: fixed;
        top: 475px;
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
#Panel1{
    position: fixed;
}
#Panel4{
    position: fixed;
}
#Label12{
    position: fixed;
        top: 174px;
        left: 297px;
        height: 80px;
        width: 220px;
    }
#Label13{
    position: fixed;
        top: 293px;
        left: 296px;
        height: 84px;
        width: 217px;
        right: 784px;
    }
#Label14{
    position: fixed;
        top: 414px;
        left: 294px;
        height: 88px;
        width: 221px;
    }
#Label15{
    position: fixed;
        top: 178px;
        left: 559px;
        height: 72px;
        width: 214px;
    }
#Label16{
    position: fixed;
        top: 291px;
        left: 560px;
        height: 88px;
        width: 218px;
    }
#Label17{
    position: fixed;
        top: 414px;
        left: 556px;
        height: 88px;
        width: 219px;
    }
#Label18{
    position: fixed;
        top: 415px;
        left: 821px;
        height: 88px;
        width: 225px;
    }
#Label19{
    position: fixed;
        top: 413px;
        left: 1082px;
        height: 88px;
        width: 218px;
    }

</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div style="height: 565px; width: 1441px;">
            
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" /> 
                        
            
            <asp:Label ID="Label12" runat="server" BackColor="#66FFFF"></asp:Label>
            
                
                
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
            <asp:Label ID="Label13" runat="server" BackColor="#9966FF"></asp:Label>
            
                
                
            <asp:Label ID="Label14" runat="server" BackColor="#99CCFF"></asp:Label>
            
                
                
            <asp:Label ID="Label15" runat="server" BackColor="#FFFF99"></asp:Label>
            
                
                
            <asp:Label ID="Label16" runat="server" BackColor="#FF99FF"></asp:Label>
            
                
                
            <asp:Label ID="Label17" runat="server" BackColor="#FF9966"></asp:Label>
            
                
                
            <asp:Label ID="Label18" runat="server" BackColor="#99FF99"></asp:Label>
            
                
                
            <asp:Label ID="Label19" runat="server" BackColor="#CC66FF"></asp:Label>
            
                
                
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Logout</asp:ListItem>
        </asp:DropDownList>
        <div style="height: 546px">
            <asp:HyperLink ID="Label2" runat="server" NavigateUrl="AdminHome.aspx" Text="Home" ForeColor="#B03E3E" Font-Underline="False" ></asp:HyperLink>
            <asp:HyperLink ID="Label3" runat="server" NavigateUrl="~/AdminPages/AdminDashboard.aspx" Text="Dashboard" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label4" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx" Text="Subjects" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label5" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx" Text="Faculty" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label6" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx" Text="Students" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label7" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx" Text="Sections" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label8" runat="server" NavigateUrl="~/AdminPages/AdminSchoolYearCalendar.aspx" Text="School Year" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:Label ID="Label11" runat="server" Text="Welcome To Dashboard," Font-Names="Arial" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="Admin" Font-Names="Arial" ForeColor="#33CC33"></asp:Label>

            <asp:hyperlink id="link" runat="server" NavigateUrl="~/AdminPages/AdminHome.aspx">
<asp:Image ID="Image3" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink1" runat="server" NavigateUrl="~/AdminPages/AdminDashboard.aspx">
<asp:Image ID="Image4" img src="HomeImages/🦆%20icon%20_dashboard_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx">
<asp:Image ID="Image5" img src="HomeImages/🦆%20icon%20_book_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink3" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx">
<asp:Image ID="Image6" img src="HomeImages/🦆%20icon%20_clipboard_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink4" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx">
<asp:Image ID="Image7" img src="HomeImages/🦆%20icon%20_people_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink5" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx">
<asp:Image ID="Image8" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink6" runat="server" NavigateUrl="~/AdminPages/AdminSchoolYearCalendar.aspx">
<asp:Image ID="Image9" img src="HomeImages/🦆%20icon%20_calendar_.png"  runat="server" />
</asp:hyperlink>

        </div>
    </form>
    
</body>
</html>
